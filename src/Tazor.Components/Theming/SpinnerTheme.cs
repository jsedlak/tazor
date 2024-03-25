namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the spinner component
/// </summary>
public class SpinnerTheme
{
    /// <summary>
    /// Gets or Sets the CSS classes for the wrapper around the spinner
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the built-in spinner (a div)
    /// </summary>
    public string SpinnerDiv { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the div around a custom provided spinner icon
    /// </summary>
    public string SpinnerIcon { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the text
    /// </summary>
    public string Text { get; set; } = string.Empty;
}