using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Provides a way to display that a background process is working
/// </summary>
public partial class Spinner : TazorBaseComponent
{
    /// <summary>
    /// Gets or Sets text to display
    /// </summary>
    [Parameter]
    public string? Text { get; set; } = null;

    /// <summary>
    /// Gets or Sets the optional icon to use
    /// </summary>
    [Parameter]
    public MarkupString? Icon { get; set; } = null;
}
