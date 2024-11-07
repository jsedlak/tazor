using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Layout;

/// <summary>
/// Renders a generic page level overlay
/// </summary>
public partial class Overlay : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets whether the overlay is visible
    /// </summary>
    [Parameter]
    public bool IsVisible { get; set; } = false;

    /// <summary>
    /// Gets or Sets the child content to render within the overlay
    /// </summary>
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the CSS class of the content
    /// </summary>
    [Parameter]
    public string? ContentClass { get; set; } = null;
}
