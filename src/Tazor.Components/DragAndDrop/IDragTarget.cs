namespace Tazor.Components.DragAndDrop;

/// <summary>
/// Provides a place to drop an item
/// </summary>
public interface IDragTarget
{
    /// <summary>
    /// Handles dropping an item on the target
    /// </summary>
    /// <param name="draggedObject"></param>
    /// <returns></returns>
    Task CompleteDrag(object draggedObject);
}