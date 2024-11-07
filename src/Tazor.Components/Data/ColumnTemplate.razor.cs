using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Provides a templated column component for the <see cref="TemplatedGrid{TItem}"/> component
/// </summary>
/// <typeparam name="TItem">The type of item being rendered in the grid</typeparam>
[CascadingTypeParameter(nameof(TItem))]
public partial class ColumnTemplate<TItem> : TazorBaseComponent, IDisposable
{
    private bool _isDisposed = false;

    /// <summary>
    /// Deconstructor
    /// </summary>
    ~ColumnTemplate()
    {
        Dispose(false);
    }

    /// <summary>
    /// Initializes the component
    /// </summary>
    protected override void OnInitialized()
    {
        Console.WriteLine("OnInitialized ColumnTemplate");
        Grid.AddColumn(this);

        base.OnInitialized();
    }

    /// <summary>
    /// Disposes the component
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
    }

    /// <summary>
    /// Disposes the component
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            GC.SuppressFinalize(this);
        }

        Grid.RemoveColumn(this);
    }

    /// <summary>
    /// Gets or Sets the order in which to display this column
    /// </summary>
    [Parameter]
    public int Order { get; set; } = 0;

    /// <summary>
    /// Gets or Sets the header rendering
    /// </summary>
    [Parameter]
    public RenderFragment Header { get; set; } = null!;
    
    public virtual RenderFragment HeaderRendering => b =>
    {
        b.OpenElement(0, "th");
        b.AddAttribute(1, "class", Theme.Data.DataGrid.HeaderCell);
        b.AddContent(2, Header);
        b.CloseElement();
    };

    /// <summary>
    /// Gets or Sets the rendering for cells of this column
    /// </summary>
    [Parameter]
    public RenderFragment<TItem> Cell { get; set; } = null!;

    public virtual RenderFragment<TItem> CellRendering => item => b =>
    {
        b.OpenElement(0, "td");
        b.AddAttribute(1, "class", Theme.Data.DataGrid.Cell);
        b.AddContent(2, Cell(item));
        b.CloseElement();
    };

    /// <summary>
    /// Gets or Sets the cascaded parent grid
    /// </summary>
    [CascadingParameter(Name = "Grid")]
    public TemplatedGrid<TItem> Grid { get; set; } = null!;

    /// <summary>
    /// Gets whether the component is disposed of
    /// </summary>
    public bool IsDisposed => _isDisposed;
}
