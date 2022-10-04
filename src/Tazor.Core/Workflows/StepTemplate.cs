namespace Tazor.Workflows;

public class StepTemplate
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Order { get; set; } = 0;
}