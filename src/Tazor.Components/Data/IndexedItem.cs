namespace Tazor.Components.Data;

/// <summary>
/// Context for rendering a range column
/// </summary>
/// <typeparam name="TItem"></typeparam>
public class IndexedItem<TItem>
{
    /// <summary>
    /// The index of the item being rendered
    /// </summary>
    public int Index { get; set; } = 0;
    
    /// <summary>
    /// The item to be rendered
    /// </summary>
    public TItem Item { get; set; } = default!;
}