namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the dialog
/// </summary>
public class DialogTheme
{
    /// <summary>
    /// Gets or Sets CSS classes for the dialog window
    /// </summary>
    public string Window { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets CSS classes for the overlay
    /// </summary>
    public string Overlay { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the placement container
    /// </summary>
    public string Placement { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for inside container of the window
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
