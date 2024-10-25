using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

[CascadingTypeParameter(nameof(TItem))]
public partial class TemplatedGrid<TItem> : TazorBaseComponent
{
    private List<ColumnTemplate<TItem>> _columns = new();

    protected override void OnInitialized()
    {
        _columns.Clear();

        base.OnInitialized();
    }

    internal void AddColumn(ColumnTemplate<TItem> column)
    {
        _columns.Add(column);
        StateHasChanged();
    }

    internal void RemoveColumn(ColumnTemplate<TItem> column)
    {
        _columns.Remove(column);
        StateHasChanged();
    }

    private string GetContainerClass()
    {
        return IsExpanded ? Theme.Data.DataGrid.ContainerExpanded : Theme.Data.DataGrid.ContainerCollapsed;
    }

    protected virtual async Task OnToggleExpansionClicked()
    {
        if(IsExpanded)
        {
            await Collapse(); 
        }
        else
        {
            await Expand();
        }
    }

    private async Task Expand()
    {
        IsExpanded = true;
        await IsExpandedChanged.InvokeAsync(true);
    }

    private async Task Collapse()
    {
        IsExpanded = false;
        await IsExpandedChanged.InvokeAsync(false);
    }

    private string GetRowClass(int index, TItem item)
    {
        var rowClass = index % 2 == 0 ? Theme.Data.DataGrid.EvenRow : Theme.Data.DataGrid.OddRow;

        if (RowClassCallback != null)
        {
            rowClass += " " + RowClassCallback(item);
        }
        
        return rowClass;
    }

    [Parameter]
    public RenderFragment? ChildContent { get; set; } = null;

    [Parameter]
    public IEnumerable<TItem> Items { get; set; } = null!;

    [Parameter]
    public bool IsExpanded { get; set; } = false;

    [Parameter]
    public EventCallback<bool> IsExpandedChanged { get; set; } = default;
    
    [Parameter]
    public Func<TItem, string>? RowClassCallback { get; set; }
}
