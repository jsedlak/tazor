namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the popover component
/// </summary>
public class PopoverTheme
{
    /// <summary>
    /// Gets or Sets css classes for the container (the relative reference point)
    /// </summary>
    public string Container { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets css classes for the wrapper
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the css classes for when the wrapper is open
    /// </summary>
    public string WrapperOpen { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the css classes for the title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the css classes for content
    /// </summary>
    public string Content { get; set; } = string.Empty;
}
