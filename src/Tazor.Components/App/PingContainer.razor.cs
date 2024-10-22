using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

public partial class PingContainer : TazorBaseComponent
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
