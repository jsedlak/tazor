namespace Tazor.Workflows;

public class Step
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = null!;

    public Guid TemplateId { get; set; }

    public IEnumerable<TraceMessage> Messages { get; set; } = Enumerable.Empty<TraceMessage>();

    public ExecutionStatus Status { get; set; } = ExecutionStatus.Default;

    public int Order { get; set; } = 0;

    public string Type { get; set; } = null!;
}
