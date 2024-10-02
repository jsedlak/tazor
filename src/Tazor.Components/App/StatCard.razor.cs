using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

public partial class StatCard : TazorBaseComponent
{
    [Parameter]
    public RenderFragment Title { get; set; } = null!;

    [Parameter]
    public RenderFragment? AdditionalData { get; set; }

    [Parameter]
    public RenderFragment Statistic { get; set; } = null!;

    [Parameter]
    public RenderFragment? Note { get; set; }
}
