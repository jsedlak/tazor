using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Provides a block of organized content
/// </summary>
public partial class Section : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the children renderings
    /// </summary>
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;
}
