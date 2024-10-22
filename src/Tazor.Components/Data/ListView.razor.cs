using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

[CascadingTypeParameter(nameof(TItem))]
public partial class ListView<TItem> : TazorBaseComponent
{
    [Parameter]
    public IEnumerable<TItem> Items { get; set; } = [];

    [Parameter]
    public RenderFragment<TItem>? ItemTemplate { get; set; } = null;
}
