using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Navigation;

public partial class Breadcrumb : TazorBaseComponent
{
    [Parameter]
    public IEnumerable<NavItem> Items { get; set; } = Enumerable.Empty<NavItem>();

    [Parameter]
    public string Delimiter { get; set; } = "/";

    [Parameter]
    public RenderFragment? DelimiterTemplate { get; set; } = null;
}
