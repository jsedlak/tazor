using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;

namespace Tazor.Components.DragAndDrop;

public partial class DropZone<TTarget> : TazorBaseComponent, IDragTarget
{
    private IDragProvider _dragProvider;

    public DropZone(IDragProvider dragProvider)
    {
        _dragProvider = dragProvider;
    }

    protected override void OnInitialized()
    {
        _dragProvider.PropertyChanged += (sender, args) =>
        {
            StateHasChanged();
        };

        base.OnInitialized();
    }

    private void OnDragEnter(DragEventArgs obj)
    {
        Console.WriteLine("DropZone.DragEnter");
        _dragProvider.DragTarget = this;
    }

    private void OnDragLeave(DragEventArgs obj)
    {
        Console.WriteLine("DropZone.DragLeave");
        if (_dragProvider.DragTarget == this)
        {
            _dragProvider.DragTarget = null;
        }
    }

    public Task CompleteDrag(object draggedObject)
    {
        Console.WriteLine("CompleteDrag");
        return Task.CompletedTask;
    }

    private async Task OnDragDropped(DragEventArgs arg)
    {
        Console.WriteLine("OnDragDropped");
        await _dragProvider.DragSource?.CompleteDrag(_dragProvider.DraggedObject);
        await Dropped.InvokeAsync(_dragProvider.DraggedObject);
    }

    [Parameter] public bool Visible { get; set; } = false;

    [Parameter] public EventCallback<bool> VisibleChanged { get; set; }

    [Parameter] public RenderFragment Content { get; set; }

    [Parameter] public EventCallback<object> Dropped { get; set; }
}
