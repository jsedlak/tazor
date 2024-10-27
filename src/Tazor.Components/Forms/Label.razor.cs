using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

/// <summary>
/// Create a label component that can be attached to a form component
/// </summary>
public partial class Label : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the child content within the label
    /// </summary>
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;
}
