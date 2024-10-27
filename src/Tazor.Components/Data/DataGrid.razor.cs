using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Provides a tabular view on a set of data
/// </summary>
/// <typeparam name="TItem"></typeparam>
[Obsolete("Use TemplatedGrid instead")]
[CascadingTypeParameter(nameof(TItem))]
public partial class DataGrid<TItem> : TazorBaseComponent 
{
    private bool _isColumnPopupOpen = false;

    private string CetColumnPopupClass() => _isColumnPopupOpen ? "block" : "hidden";

    private void HandleSortChange(Column<TItem> col)
    {
        if (!Sortable)
        {
            return;
        }

        col.Sort = col.Sort switch
        {
            SortDirection.None => SortDirection.Ascending,
            SortDirection.Ascending => SortDirection.Descending,
            SortDirection.Descending => SortDirection.None,
            _ => col.Sort
        };

        if (EnableMultiSort)
        {
            return;
        }
        
        foreach (var otherColumn in Columns.Where(m => m != col))
        {
            otherColumn.Sort = SortDirection.None;
        }
    }

    /// <summary>
    /// Gets or Sets the toolbar rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Toolbar { get; set; }

    /// <summary>
    /// Gets or Sets the number of items to render on each page
    /// </summary>
    [Parameter]
    public int NumberPerPage { get; set; } = 10;

    /// <summary>
    /// Gets or Sets the current page number
    /// </summary>
    [Parameter]
    public int CurrentPage { get; set; } = 1;

    /// <summary>
    /// Gets or Sets the data set to render
    /// </summary>
    [Parameter]
    public IEnumerable<TItem> Items { get; set; } = Enumerable.Empty<TItem>();

    /// <summary>
    /// Gets or Sets the columns to render
    /// </summary>
    [Parameter]
    public IEnumerable<Column<TItem>> Columns { get; set; } = Enumerable.Empty<Column<TItem>>();

    /// <summary>
    /// Gets or Sets the summary row mode
    /// </summary>
    [Parameter]
    public SummaryRowMode SummaryRow { get; set; }

    /// <summary>
    /// Gets or Sets whether the grid is sortable
    /// </summary>
    [Parameter]
    public bool Sortable { get; set; } = true;

    /// <summary>
    /// Gets or Sets whether multiple column sorts are allowed
    /// </summary>
    [Parameter]
    public bool EnableMultiSort { get; set; } = false;

    /// <summary>
    /// Gets or Sets the edit callback
    /// </summary>
    [Parameter]
    public Action<TItem>? OnEdit { get; set; }

    /// <summary>
    /// Gets or Sets the delete callback
    /// </summary>
    [Parameter]
    public Action<TItem>? OnDelete { get; set; }

    /// <summary>
    /// Gets or Sets a list of additional commands to render
    /// </summary>
    [Parameter]
    public IEnumerable<CommandItem> AdditionalActions { get; set; } = Enumerable.Empty<CommandItem>();

    /// <summary>
    /// Gets or Sets the callback for when an action/command is clicked
    /// </summary>
    [Parameter]
    public Action<TItem, CommandItem>? ActionRequested { get; set; }

    /// <summary>
    /// Gets or Sets wheter to display the toolbar
    /// </summary>
    [Parameter]
    public bool HideToolbar { get; set; } = false;

    /// <summary>
    /// Gets or Sets the callback for showing the delete button
    /// </summary>
    [Parameter]
    public Func<TItem, bool>? RequestShowDelete { get; set; }

    /// <summary>
    /// Gets or Sets the callback for showing the edit button
    /// </summary>
    [Parameter]
    public Func<TItem, bool>? RequestShowEdit { get; set; }
}
