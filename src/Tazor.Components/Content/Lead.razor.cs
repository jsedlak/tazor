using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Lead : TazorBaseComponent
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool AsDiv { get; set; }
}
