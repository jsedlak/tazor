using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

public partial class ColumnTemplate<TItem> : TazorBaseComponent, IDisposable
{
    private bool _isDisposed = false;

    ~ColumnTemplate()
    {
        Dispose(false);
    }

    protected override void OnInitialized()
    {
        Console.WriteLine("OnInitialized ColumnTemplate");
        Grid.AddColumn(this);

        base.OnInitialized();
    }

    public void Dispose()
    {
        Dispose(true);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            GC.SuppressFinalize(this);
        }

        Grid.RemoveColumn(this);
    }

    [Parameter]
    public int Order { get; set; } = 0;

    [Parameter]
    public RenderFragment Header { get; set; } = null!;

    [Parameter]
    public RenderFragment<TItem> Cell { get; set; } = null!;

    [CascadingParameter(Name = "Grid")]
    public TemplatedGrid<TItem> Grid { get; set; } = null!;

    public bool IsDisposed => _isDisposed;
}
