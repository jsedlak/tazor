namespace Tazor.Components.Layout;

public interface IDragSource
{
    Task CompleteDrag(object draggedObject);
}