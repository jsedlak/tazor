using System.ComponentModel;

namespace Tazor.Components.Layout;

/// <summary>
/// Provides dragging capabilities to the tazor controls
/// </summary>
public interface IDragProvider : INotifyPropertyChanged
{
    /// <summary>
    /// Gets or Sets the object being dragged
    /// </summary>
    object? DraggedObject { get; set; }
    
    /// <summary>
    /// Gets or Sets the potential target for dropping
    /// </summary>
    IDragTarget? DragTarget { get; set; }
    
    /// <summary>
    /// Gets or Sets the place the object was dragged from
    /// </summary>
    IDragSource? DragSource { get; set; }
}