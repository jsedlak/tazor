namespace Tazor.Workflows;

public class FunctionalWorkflowAction : WorkflowAction
{
    private readonly Func<WorkflowContext, Task> _executeFunction;
    private readonly Func<WorkflowContext, Task<bool>>? _canExecuteFunction;

    public FunctionalWorkflowAction(Func<WorkflowContext, Task> executeFn, Func<WorkflowContext, Task<bool>>? canExecuteFn = null)
    {
        _executeFunction = executeFn;
        _canExecuteFunction = canExecuteFn;
    }

    public override Task<bool> CanExecuteAsync(WorkflowContext context)
    {
        if(_canExecuteFunction != null)
        {
            return _canExecuteFunction(context);
        }

        return base.CanExecuteAsync(context);
    }
    public override Task ExecuteAsync(WorkflowContext context)
    {
        return _executeFunction(context);
    }
}