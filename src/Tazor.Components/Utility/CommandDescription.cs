namespace Tazor.Components.Utility;

public class CommandDescription
{
    public string Name { get; set; } = null!;

    public Func<string, string> Describe { get; set; } = (_) => "";

    public Func<string, bool> CanExecute { get; set; } = (_) => false;

    public Func<string, Task> ExecuteAsync { get; set; } = (_) => Task.CompletedTask;
}
