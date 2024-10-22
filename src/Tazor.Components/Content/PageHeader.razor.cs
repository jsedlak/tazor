using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class PageHeader : TazorBaseComponent
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
