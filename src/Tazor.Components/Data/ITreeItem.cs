using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Describes an item that can be rendered in a tree based interface
/// </summary>
public interface ITreeItem
{
    /// <summary>
    /// Gets or Sets the title of the item
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Gets or Sets the icon to display
    /// </summary>
    MarkupString Icon { get; set; }

    /// <summary>
    /// Gets or Sets the children tree items
    /// </summary>
    IEnumerable<ITreeItem> Children { get; set; }

    /// <summary>
    /// Gets or Sets whether the item is expanded
    /// </summary>
    bool IsExpanded { get; set; }
}
