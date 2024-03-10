namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the tab navigation component
/// </summary>
public class TabNavTheme
{
    /// <summary>
    /// Gets or Sets the CSS class for the wrapper of the tab nav
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS class for selected item
    /// </summary>
    public string SelectedItem { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS class for a tab nav item
    /// </summary>
    public string Item { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS class for the selected item's link
    /// </summary>
    public string SelectedLink { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS class for an item's link
    /// </summary>
    public string Link { get; set; } = string.Empty;
}
