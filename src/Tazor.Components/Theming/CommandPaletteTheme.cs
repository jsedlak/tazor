namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the command palette
/// </summary>
public class CommandPaletteTheme
{
    /// <summary>
    /// Gets or Sets the CSS classes for the wrapper of the command palette
    /// </summary>
    public string Wrapper { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS classes for the palette itself
    /// </summary>
    public string Palette { get; set; } = "";
    
    /// <summary>
    /// Gets or Sets the CSS classes for the input
    /// </summary>
    public string Input { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS classes for the list element
    /// </summary>
    public string List { get; set; } = "";

    /// <summary>
    /// Gets or Sets CSS classes for the list items
    /// </summary>
    public string ListItem { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS classes for selected list items
    /// </summary>
    public string ListItemActive { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS class for a command name
    /// </summary>
    public string CommandName { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS class for a command description
    /// </summary>
    public string CommandDescription { get; set; } = "";
}
