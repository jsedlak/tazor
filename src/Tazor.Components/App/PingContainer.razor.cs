using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

/// <summary>
/// Provides the rendering for a relative positioner for the Ping component
/// </summary>
public partial class PingContainer : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the child content
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
