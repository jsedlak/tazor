namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for buttons
/// </summary>
public class ButtonTheme
{
    /// <summary>
    /// Gets or Sets the global style applied to all buttons
    /// </summary>
    public string Global { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the style applied to disabled buttons
    /// </summary>
    public string Disabled { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the style applied to primary buttons
    /// </summary>
    public string Primary { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for primary buttons with an outline
    /// </summary>
    public string PrimaryOutline { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS Classes for the default button
    /// </summary>
    public string Default { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the default button with an outline
    /// </summary>
    public string DefaultOutline { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the info button
    /// </summary>
    public string Info { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the info button with an outline
    /// </summary>
    public string InfoOutline { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the warning button
    /// </summary>
    public string Warning { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the warning button with an outline
    /// </summary>
    public string WarningOutline { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the danger button
    /// </summary>
    public string Error { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the danger button with an outline
    /// </summary>
    public string ErrorOutline { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the link button
    /// </summary>
    public string Link { get; set; }= string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for success buttons
    /// </summary>
    public string Success { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for success buttons with an outline
    /// </summary>
    public string SuccessOutline { get; set; } = string.Empty;
}
