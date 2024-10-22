using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Layout;

public partial class Overlay : TazorBaseComponent
{
    [Parameter]
    public bool IsVisible { get; set; } = false;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;

    [Parameter]
    public string? ContentClass { get; set; } = null;
}
