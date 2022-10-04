namespace Tazor.Workflows;

public class WorkflowTemplate
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = null!;

    public IEnumerable<StepTemplate> Steps { get; set; } = Enumerable.Empty<StepTemplate>();
}
