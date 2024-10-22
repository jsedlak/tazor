using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

public partial class Ping : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the content of the ping, usually a number
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
