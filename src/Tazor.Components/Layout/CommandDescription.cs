namespace Tazor.Components.Layout;

/// <summary>
/// Describes a command accessible via the Command Palette component
/// </summary>
public class CommandDescription
{
    /// <summary>
    /// Gets or Sets the name of the command
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or Sets a callback for describing the command (showing the description in the UI)
    /// </summary>
    public Func<string, string> Describe { get; set; } = (_) => "";

    /// <summary>
    /// Gets or Sets the callback for deciding if it may execute
    /// </summary>
    public Func<string, bool> CanExecute { get; set; } = (_) => false;

    /// <summary>
    /// Gets or Sets the callback to execute the command
    /// </summary>
    public Func<string, Task> ExecuteAsync { get; set; } = (_) => Task.CompletedTask;
}
