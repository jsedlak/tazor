using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Provides a common way to top the page with a header
/// </summary>
public partial class PageHeader : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets the child content rendering
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
