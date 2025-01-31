using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Layout;

/// <summary>
/// Provides common functionality for dialogs
/// </summary>
public abstract class DialogBase : TazorBaseComponent
{
    private readonly IJSRuntime _jsRuntime;
    private bool _wasVisible = false;

    protected DialogBase(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    protected override async Task OnParametersSetAsync()
    {
        if (_wasVisible != IsVisible)
        {
            _wasVisible = IsVisible;
            if (_wasVisible)
            {
                await _jsRuntime.InvokeVoidAsync("openDialog", [ReferenceId]);
            }
            else
            {
                await _jsRuntime.InvokeVoidAsync("closeDialog", [ReferenceId]);
            }
        }
    }

    protected async Task OnCloseRequested()
    {
        IsVisible = false;

        if (IsVisibleChanged.HasDelegate)
        {
            await IsVisibleChanged.InvokeAsync(false);
        }
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
    /// Gets or Sets the title of the dialog which should render if the <see cref="Header"/> isn't available
    /// </summary>
    [Parameter]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or Sets the header rendering, which overrides the <see cref="Title"/> property
    /// </summary>
    public RenderFragment? Header { get; set; }

    /// <summary>
    /// Gets or Sets the content rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Content { get; set; }

    /// <summary>
    /// Gets or Sets the footer rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Footer { get; set; }

    /// <summary>
    /// Gets or Sets the reference id, which the javascript uses to open/close the dialog
    /// </summary>
    [Parameter]
    public Guid ReferenceId { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Gets or Sets optional additional classing, useful for sizing adjustments
    /// </summary>
    [Parameter]
    public string CustomClass { get; set; } = string.Empty;
}
