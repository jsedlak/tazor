using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Panel : TazorBaseComponent
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;
}
