namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the flyout component
/// </summary>
public class FlyoutTheme
{
    /// <summary>
    /// Gets or Sets the CSS class for the overlay
    /// </summary>
    public string Overlay { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for when the flyout is placed to the left
    /// </summary>
    public string PlacementLeft { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for when the flyout is placed to the right
    /// </summary>
    public string PlacementRight { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for when the flyout is placed to the top
    /// </summary>
    public string PlacementTop { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for when the flyout is placed to the bottom
    /// </summary>
    public string PlacementBottom { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the window
    /// </summary>
    public string Window { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the window when placed horizontally
    /// </summary>
    public string WindowHorizontal { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the window when placed vertically
    /// </summary>
    public string WindowVertical { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the interior of the window
    /// </summary>
    public string WindowInner { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the header
    /// </summary>
    public string Header { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the content
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the footer
    /// </summary>
    public string Footer { get; set; } = string.Empty;
}