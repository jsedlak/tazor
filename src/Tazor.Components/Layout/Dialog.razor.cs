using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Layout;

public partial class Dialog : TazorBaseComponent
{
    private async Task OnCloseRequested()
    {
        IsVisible = false;
        await IsVisibleChanged.InvokeAsync(false);
    }

    [Parameter]
    public bool IsVisible { get; set; } = false;

    [Parameter]
    public EventCallback<bool> IsVisibleChanged { get; set; }

    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public RenderFragment? Header { get; set; }

    [Parameter]
    public RenderFragment Content { get; set; } = null!;

    [Parameter]
    public RenderFragment Footer { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the extra CSS Classes on the window item, ideal for setting width and height attributes
    /// </summary>
    [Parameter] public string? WindowClass { get; set; }

    [Parameter]
    public bool HideCloseButton { get; set; } = false;
}
