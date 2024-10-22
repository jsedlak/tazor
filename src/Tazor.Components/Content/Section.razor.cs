using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Section : TazorBaseComponent
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;
}
