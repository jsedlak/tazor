using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

public partial class SubLabel : TazorBaseComponent
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;
}
