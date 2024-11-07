using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Informs the <see cref="DataGrid{TItem}"/> on how to render the footer column
/// </summary>
public enum SummaryRowMode
{
    /// <summary>
    /// Hidden
    /// </summary>
    Hidden,
    
    /// <summary>
    /// Render for all items
    /// </summary>
    AllItems,
    
    /// <summary>
    /// Render for visible items
    /// </summary>
    VisibleItems
}