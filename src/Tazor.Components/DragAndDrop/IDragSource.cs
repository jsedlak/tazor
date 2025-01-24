namespace Tazor.Components.DragAndDrop;

/// <summary>
/// Provides a place for an item to be dragged from
/// </summary>
public interface IDragSource
{
    /// <summary>
    /// Handles completing a drag to another object
    /// </summary>
    /// <param name="draggedObject"></param>
    /// <returns></returns>
    Task CompleteDrag(object draggedObject);
}