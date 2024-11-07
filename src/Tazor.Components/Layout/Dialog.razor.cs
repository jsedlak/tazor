using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Layout;

/// <summary>
/// Renders an overlayed dialog
/// </summary>
public partial class Dialog : TazorBaseComponent
{
    private async Task OnCloseRequested()
    {
        IsVisible = false;
        await IsVisibleChanged.InvokeAsync(false);
    }

    /// <summary>
    /// Gets or Sets whether the dialog is visible
    /// </summary>
    [Parameter]
    public bool IsVisible { get; set; } = false;

    /// <summary>
    /// Gets or Sets the callback for handling when visibility has changed
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsVisibleChanged { get; set; }

    /// <summary>
    /// Gets or Sets the title of the dialog
    /// </summary>
    [Parameter]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or Sets the header rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Header { get; set; }

    /// <summary>
    /// Gets or Sets the content rendering
    /// </summary>
    [Parameter]
    public RenderFragment Content { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the footer rendering
    /// </summary>
    [Parameter]
    public RenderFragment Footer { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the extra CSS Classes on the window item, ideal for setting width and height attributes
    /// </summary>
    [Parameter] public string? WindowClass { get; set; }

    /// <summary>
    /// Gets or Sets whether the close button should be rendered
    /// </summary>
    [Parameter]
    public bool HideCloseButton { get; set; } = false;
}
