namespace Tazor.Workflows;

public class WorkflowProcessingEngine
{
    private readonly IWorkflowRepository _workflowRepository;

    public WorkflowProcessingEngine(IWorkflowRepository workflowRepository)
    {
        _workflowRepository = workflowRepository;
    }

    public async Task<Guid> InitializeWorkflowAsync(WorkflowRequest workflowRequest)
    {
        var template = await _workflowRepository.GetTemplateAsync(workflowRequest.TemplateId);

        var workflow = new Workflow
        {
            Name = template.Name,
            Data = workflowRequest.Data,
            TemplateId = workflowRequest.TemplateId,
            Status = ExecutionStatus.Default,
            Steps = template.Steps.OrderBy(m => m.Order).Select(m => new Step
            {
                Name = m.Name,
                TemplateId = m.Id,
                Type = m.Type,
                Order = m.Order,
                Status = ExecutionStatus.Default
            })
        };

        await _workflowRepository.UpsertWorkflowAsync(workflow);
        return workflow.Id;
    }

    public async Task ExecuteAsync(Guid workflowId)
    {
        var workflow = await _workflowRepository.GetWorkflowAsync(workflowId);
        // var template = await _workflowRepository.GetTemplateAsync(workflow.TemplateId);

        var context = new WorkflowContext
        {
            Instance = workflow,
            Repository = _workflowRepository
        };

        foreach (var step in workflow.Steps)
        {
            if (context.IsCancelled)
            {
                break;
            }

            var actionType = Type.GetType(step.Type);

            if (actionType == null)
            {
                // TODO: Do something
                context.IsCancelled = true;
                continue;
            }

            var actionObject = Activator.CreateInstance(actionType);

            if (actionObject == null)
            {
                // TODO: Do something
                context.IsCancelled = true;
                continue;
            }

            var action = actionObject as WorkflowAction;

            if (action == null)
            {
                // TODO: Do something
                context.IsCancelled = true;
                continue;
            }

            // can we execute it?
            if(!await action.CanExecuteAsync(context))
            {
                step.Status = ExecutionStatus.Skipped;
                await _workflowRepository.UpsertWorkflowAsync(workflow);
                continue;
            }

            // set the status and update the storage
            step.Status = ExecutionStatus.Executing;
            await _workflowRepository.UpsertWorkflowAsync(workflow);

            // execute it!
            try
            {
                await action.ExecuteAsync(context);
                step.Status = ExecutionStatus.Finished;
            }
            catch (Exception ex)
            {
                step.Status = ExecutionStatus.Errored;
                step.Messages = step.Messages.Append(TraceMessage.FromException(ex));
                context.IsCancelled = true;
            }

            // update if there were messages
            await _workflowRepository.UpsertWorkflowAsync(workflow);
        }

        // one final update
        workflow.Status = ExecutionStatus.Finished;
        await _workflowRepository.UpsertWorkflowAsync(workflow);
    }
}
