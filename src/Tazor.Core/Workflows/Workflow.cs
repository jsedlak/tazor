namespace Tazor.Workflows;

public class Workflow
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = null!;

    public Guid TemplateId { get; set; }

    public IEnumerable<Step> Steps { get; set; } = Enumerable.Empty<Step>();

    public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();

    public object? Data { get; set; }

    public ExecutionStatus Status { get; set; } = ExecutionStatus.Default;
}
