using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Provides a method for displaying a set of commands for a row in the <see cref="DataGrid{TItem}"/>
/// </summary>
public class CommandItem
{
    /// <summary>
    /// Gets or Sets the title of the command
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the identifying key
    /// </summary>
    public string Key { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the icon to display
    /// </summary>
    public MarkupString Icon { get; set; }
}
