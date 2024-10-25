using System.ComponentModel;

namespace Tazor.Components.Layout;

public interface IDragProvider : INotifyPropertyChanged
{
    object? DraggedObject { get; set; }
    
    IDragTarget? DragTarget { get; set; }
    
    IDragSource? DragSource { get; set; }
}