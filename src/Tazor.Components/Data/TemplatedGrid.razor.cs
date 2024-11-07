using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Renders a tabular view of a dataset
/// </summary>
/// <typeparam name="TItem"></typeparam>
[CascadingTypeParameter(nameof(TItem))]
public partial class TemplatedGrid<TItem> : TazorBaseComponent
{
    private List<ColumnTemplate<TItem>> _columns = new();

    /// <summary>
    /// Initializes the component
    /// </summary>
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

    /// <summary>
    /// Expands or Collapses the Grid
    /// </summary>
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

    /// <summary>
    /// Gets or Sets the child content, typically a set of <see cref="ColumnTemplate{TItem}"/> components
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; } = null;

    /// <summary>
    /// Gets or Sets the data to render
    /// </summary>
    [Parameter]
    public IEnumerable<TItem> Items { get; set; } = null!;

    /// <summary>
    /// Gets or Sets whether the grid is expanded
    /// </summary>
    [Parameter]
    public bool IsExpanded { get; set; } = false;

    /// <summary>
    /// Gets or Sets the callback for when the grid expands or collapses
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsExpandedChanged { get; set; } = default;
    
    /// <summary>
    /// Gets or Sets the callback for adding to the row CSS class string
    /// </summary>
    [Parameter]
    public Func<TItem, string>? RowClassCallback { get; set; }
}
