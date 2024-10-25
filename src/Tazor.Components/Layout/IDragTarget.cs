namespace Tazor.Components.Layout;

public interface IDragTarget
{
    Task CompleteDrag(object draggedObject);
}