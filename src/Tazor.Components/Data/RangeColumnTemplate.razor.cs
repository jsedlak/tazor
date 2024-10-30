using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Provides a range of columns for a dataset
/// </summary>
/// <typeparam name="TItem">The type of item being rendered in the grid</typeparam>
[CascadingTypeParameter(nameof(TItem))]
public partial class RangeColumnTemplate<TItem> : ColumnTemplate<TItem>
{
    public override RenderFragment HeaderRendering => b =>
    {
        var list = GetRange().ToArray();
        for (var i = 0; i < list.Length; i++)
        {
            var idxItem = new IndexedItem<object>()
            {
                Index = i,
                Item = list[i]
            };
            
            b.OpenElement(i + 0, "td");
            b.AddAttribute(i + 1, "class", Theme.Data.DataGrid.HeaderCell);
            b.AddContent(i + 2, IndexedHeader(idxItem));
            b.CloseElement();
        }
    };

    public override RenderFragment<TItem> CellRendering => item => b =>
    {
        var list = GetRange().ToArray();
        for (var i = 0; i < list.Length; i++)
        {
            var idxItem = new IndexedItem<object>()
            {
                Index = i,
                Item = item!
            };
            
            b.OpenElement(i + 0, "td");
            b.AddAttribute(i + 1, "class", Theme.Data.DataGrid.Cell);
            b.AddContent(i + 2, IndexedCell(idxItem));
            b.CloseElement();
        }
    };
    
    [Parameter]
    public Func<IEnumerable<object>> GetRange { get; set; } = null!;

    [Parameter]
    public RenderFragment<IndexedItem<object>> IndexedHeader { get; set; }= null!;
    
    [Parameter]
    public RenderFragment<IndexedItem<object>> IndexedCell { get; set; } = null!;
}