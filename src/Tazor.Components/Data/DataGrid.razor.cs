using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

[CascadingTypeParameter(nameof(TItem))]
public partial class DataGrid<TITem> : TazorBaseComponent 
{
    private bool _isColumnPopupOpen = false;

    private string CetColumnPopupClass() => _isColumnPopupOpen ? "block" : "hidden";

    private void HandleSortChange(Column<TItem> col)
    {
        if (!Sortable)
        {
            return;
        }

        switch (col.Sort)
        {
            case SortDirection.None:
                col.Sort = SortDirection.Ascending;
                break;
            case SortDirection.Ascending:
                col.Sort = SortDirection.Descending;
                break;
            case SortDirection.Descending:
                col.Sort = SortDirection.None;
                break;
        }

        if (!EnableMultiSort)
        {
            foreach (var otherColumn in Columns.Where(m => m != col))
            {
                otherColumn.Sort = SortDirection.None;
            }
        }
    }

    [Parameter]
    public RenderFragment? Toolbar { get; set; }

    [Parameter]
    public int NumberPerPage { get; set; } = 10;

    [Parameter]
    public int CurrentPage { get; set; } = 1;

    [Parameter]
    public IEnumerable<TItem> Items { get; set; } = Enumerable.Empty<TItem>();

    [Parameter]
    public IEnumerable<Column<TItem>> Columns { get; set; } = Enumerable.Empty<Column<TItem>>();

    [Parameter]
    public SummaryRowMode SummaryRow { get; set; }

    [Parameter]
    public bool Sortable { get; set; } = true;

    [Parameter]
    public bool EnableMultiSort { get; set; } = false;

    [Parameter]
    public Action<TItem>? OnEdit { get; set; }

    [Parameter]
    public Action<TItem>? OnDelete { get; set; }

    [Parameter]
    public IEnumerable<CommandItem> AdditionalActions { get; set; } = Enumerable.Empty<CommandItem>();

    [Parameter]
    public Action<TItem, CommandItem>? ActionRequested { get; set; }

    [Parameter]
    public bool HideToolbar { get; set; } = false;

    [Parameter]
    public Func<TItem, bool>? RequestShowDelete { get; set; }

    [Parameter]
    public Func<TItem, bool>? RequestShowEdit { get; set; }
}
