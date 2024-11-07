using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

/// <summary>
/// Renders a smaller component of text below the label
/// </summary>
public partial class SubLabel : TazorBaseComponent
{
    /// <summary>
    /// The child content to render
    /// </summary>
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;
}
