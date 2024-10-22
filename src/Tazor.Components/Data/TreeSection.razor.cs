using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Tazor.Components.Data;

public partial class TreeSection : TazorBaseComponent
{
    private int _left = 0;
    private int _top = 0;
    private bool _contextMenuVisible = false;

    protected async Task OnExpandClicked(ITreeItem item)
    {
        item.IsExpanded = !item.IsExpanded;

        if (item.IsExpanded && Tree.RequestTree != null)
        {
            item.Children = await Tree.RequestTree(item);
        }

        StateHasChanged();
    }

    protected void HandleContextMenu(ITreeItem item, MouseEventArgs args)
    {
        _left = (int)args.ClientX;
        _top = (int)args.ClientY;
        _contextMenuVisible = true;
    }

    [Parameter]
    public IEnumerable<ITreeItem> Items { get; set; } = Enumerable.Empty<ITreeItem>();

    [CascadingParameter(Name = "Tree")]
    public TreeView Tree { get; set; } = null!;
}
