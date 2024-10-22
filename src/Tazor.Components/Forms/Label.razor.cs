using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

public partial class Label : TazorBaseComponent
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;
}
