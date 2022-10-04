namespace Tazor.Workflows;

public abstract class WorkflowAction
{
    public virtual Task<bool> CanExecuteAsync(WorkflowContext context)
    {
        return Task.FromResult(true);
    }

    public abstract Task ExecuteAsync(WorkflowContext context);
}
