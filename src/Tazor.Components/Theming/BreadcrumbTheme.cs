namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the breadcrumb component
/// </summary>
public class BreadcrumbTheme
{
    /// <summary>
    /// Gets or Sets the CSS Class for the container of the Breadcrumb.
    /// </summary>
    public string Container { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS class for the list element of the breadcrumb
    /// </summary>
    public string List { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS class for the list item element of the breadcrumb
    /// </summary>
    public string ListItem { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS class for an anchor element in the breadcrumb
    /// </summary>
    public string Link { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS class for the current item
    /// </summary>
    public string CurrentItem { get; set; } = "";
}