using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Navigation;

/// <summary>
/// Renders a breadcrumb view of a linear dataset
/// </summary>
public partial class Breadcrumb : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the items to be rendered
    /// </summary>
    [Parameter]
    public IEnumerable<NavItem> Items { get; set; } = Enumerable.Empty<NavItem>();

    /// <summary>
    /// Gets or Sets the string delimiter
    /// </summary>
    [Parameter]
    public string Delimiter { get; set; } = "/";

    /// <summary>
    /// Gets or Sets the optional delimiter rendering
    /// </summary>
    [Parameter]
    public RenderFragment? DelimiterTemplate { get; set; } = null;
}
