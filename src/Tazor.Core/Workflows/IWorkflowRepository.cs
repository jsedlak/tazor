namespace Tazor.Workflows;

public interface IWorkflowRepository
{
    Task UpsertTemplateAsync(WorkflowTemplate template);

    Task<WorkflowTemplate> GetTemplateAsync(Guid templateId);

    Task<Workflow> GetWorkflowAsync(Guid workflowId);

    Task UpsertWorkflowAsync(Workflow workflow);
}