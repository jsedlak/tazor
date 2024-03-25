namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the tree view component
/// </summary>
public class TreeViewTheme
{
    /// <summary>
    /// Gets or Sets CSS classes for the wrapper of the tree view
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the top level tree (ul)
    /// </summary>
    public string Tree { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for a tree item (li)
    /// </summary>
    public string TreeItem { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for a selected tree item (li)
    /// </summary>
    public string TreeItemSelected { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the content wrapper of a tree item
    /// </summary>
    public string TreeItemContentWrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the content wrapper of a selected tree item
    /// </summary>
    public string TreeItemSelectedContentWrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the anchor element of a tree item
    /// </summary>
    public string TreeItemAnchor { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the anchor element of a selected tree item
    /// </summary>
    public string TreeItemSelectedAnchor { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the sub tree (ul) of a tree item
    /// </summary>
    public string TreeItemSubTree { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the expander icon
    /// </summary>
    public string TreeItemExpandIcon { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the anchor element of the expander icon
    /// </summary>
    public string TreeItemExpandAnchor { get; set; } = string.Empty;
}