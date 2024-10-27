using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Displays a prose in a loose and large text format
/// </summary>
public partial class Lead : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the child content rendering
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Gets or Sets whether it should be rendered as a div (default: p)
    /// </summary>
    [Parameter]
    public bool AsDiv { get; set; }
}
