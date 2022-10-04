namespace Tazor.Workflows;

public class WorkflowRequest
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid TemplateId { get; set; }

    public object? Data { get; set; }
}