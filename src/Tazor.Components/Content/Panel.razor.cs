using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Provides a common way to render a panel of content
/// </summary>
public partial class Panel : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the child content rendering
    /// </summary>
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;
}
