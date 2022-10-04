namespace Tazor.Workflows;

public class WorkflowContext
{
    public Workflow Instance { get; set; } = null!;

    public IWorkflowRepository Repository { get; set; } = null!;

    public bool IsCancelled { get; set; } = false;
}