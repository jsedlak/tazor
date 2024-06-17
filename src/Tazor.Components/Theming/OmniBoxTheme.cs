namespace Tazor.Components.Theming;

/// <summary>
/// Gets or Sets theming classes for the OmniBox Component
/// </summary>
public class OmniBoxTheme
{
    /// <summary>
    /// Gets or Sets class list for the wrapper around the omnibox
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or Sets class list for the viewer (fake input) that is visible when an item is selected / the OmniBox is not active
    /// </summary>
    public string Viewer { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or Sets the class list for the input textbox
    /// </summary>
    public string Input { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or Sets the class list for the list of search results
    /// </summary>
    public string List { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or Sets the class list for each search result
    /// </summary>
    public string ListItem { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or Sets the class list for when a search result is highlighted
    /// </summary>
    public string ListItemActive { get; set; } = string.Empty;
}