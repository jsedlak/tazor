using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Tazor.Components.Data;

/// <summary>
/// Renders a section of a <see cref="TreeView"/>
/// </summary>
public partial class TreeSection : TazorBaseComponent
{
    private int _left = 0;
    private int _top = 0;
    private bool _contextMenuVisible = false;

    /// <summary>
    /// Handles when the expan item has been clicked and the tree section needs to be expanded or collapsed
    /// </summary>
    /// <param name="item"></param>
    protected async Task OnExpandClicked(ITreeItem item)
    {
        item.IsExpanded = !item.IsExpanded;

        if (item.IsExpanded && Tree.RequestTree != null)
        {
            item.Children = await Tree.RequestTree(item);
        }

        StateHasChanged();
    }

    /// <summary>
    /// Opens the context menu
    /// </summary>
    /// <param name="item"></param>
    /// <param name="args"></param>
    protected void HandleContextMenu(ITreeItem item, MouseEventArgs args)
    {
        _left = (int)args.ClientX;
        _top = (int)args.ClientY;
        _contextMenuVisible = true;
    }

    /// <summary>
    /// Gets or Sets the items that make up this part of the tree
    /// </summary>
    [Parameter]
    public IEnumerable<ITreeItem> Items { get; set; } = Enumerable.Empty<ITreeItem>();

    /// <summary>
    /// Gets or Sets the parent <see cref="TreeView"/>
    /// </summary>
    [CascadingParameter(Name = "Tree")]
    public TreeView Tree { get; set; } = null!;
}
