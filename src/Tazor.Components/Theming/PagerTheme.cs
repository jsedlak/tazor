namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the pager component
/// </summary>
public class PagerTheme
{
    /// <summary>
    /// Gets or Sets the CSS classes for the wrapper
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the nav element
    /// </summary>
    public string Nav { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the previous button
    /// </summary>
    public string PreviousButton { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for a page button
    /// </summary>
    public string Button { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for a page button that is active/selected
    /// </summary>
    public string ButtonActive { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the next button
    /// </summary>
    public string NextButton { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the text that shows previous/next
    /// </summary>
    public string NextPreviousText { get; set; } = string.Empty;
}
