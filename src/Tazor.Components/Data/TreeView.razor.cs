using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Renders a tree view of a hiearchical dataset
/// </summary>
public partial class TreeView : TazorBaseComponent
{
    /// <summary>
    /// Handles selecting a set of items
    /// </summary>
    /// <param name="items"></param>
    public void Select(params ITreeItem[] items)
    {
        SelectedItems = items;
        SelectedItemsChanged.InvokeAsync(SelectedItems);
        StateHasChanged();
    }

    /// <summary>
    /// Gets or Sets the set of items being rendered
    /// </summary>
    [Parameter]
    public IEnumerable<ITreeItem> Items { get; set; } = Enumerable.Empty<ITreeItem>();

    /// <summary>
    /// Gets or Sets the callback for retrieving additional items on expansion
    /// </summary>
    [Parameter]
    public Func<ITreeItem, Task<IEnumerable<ITreeItem>>>? RequestTree { get; set; }

    /// <summary>
    /// Gets or Sets the items that are selected
    /// </summary>
    [Parameter]
    public IEnumerable<ITreeItem> SelectedItems { get; set; } = Enumerable.Empty<ITreeItem>();

    /// <summary>
    /// Gets or Sets the callback for handling when the selection has changed
    /// </summary>
    [Parameter]
    public EventCallback<IEnumerable<ITreeItem>> SelectedItemsChanged { get; set; }
}
