using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Provides a list interface for a dataset
/// </summary>
/// <typeparam name="TItem"></typeparam>
[CascadingTypeParameter(nameof(TItem))]
public partial class ListView<TItem> : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the set of items to render
    /// </summary>
    [Parameter]
    public IEnumerable<TItem> Items { get; set; } = [];

    /// <summary>
    /// Gets or Sets the template to render each item
    /// </summary>
    [Parameter]
    public RenderFragment<TItem>? ItemTemplate { get; set; } = null;
}
