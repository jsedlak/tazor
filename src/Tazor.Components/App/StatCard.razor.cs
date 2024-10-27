using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

/// <summary>
/// Renders a statistic card in a uniform way
/// </summary>
public partial class StatCard : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the title rendering
    /// </summary>
    [Parameter]
    public RenderFragment Title { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the additional data rendering
    /// </summary>
    [Parameter]
    public RenderFragment? AdditionalData { get; set; }

    /// <summary>
    /// Gets or Sets the statistic rendering
    /// </summary>
    [Parameter]
    public RenderFragment Statistic { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the footer/note rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Note { get; set; }
}
