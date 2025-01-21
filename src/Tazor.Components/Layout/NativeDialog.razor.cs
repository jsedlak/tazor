using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Layout;

public partial class NativeDialog : TazorBaseComponent
{
    private readonly IJSRuntime _jsRuntime;
    private bool _wasOpen = false;

    public NativeDialog(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    protected override async Task OnParametersSetAsync()
    {
        if(_wasOpen != IsOpen)
        {
            _wasOpen = IsOpen;
            if(_wasOpen)
            {
                await _jsRuntime.InvokeVoidAsync("openDialog", [ReferenceId]);
            }
            else
            {
                await _jsRuntime.InvokeVoidAsync("closeDialog", [ReferenceId]);
            }
        }
    }

    private async Task OnCloseRequested()
    {
        IsOpen = false;
        
        if (IsOpenChanged.HasDelegate)
        {
            await IsOpenChanged.InvokeAsync(false);
        }
    }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public bool HideCloseButton { get; set; }

    [Parameter]
    public bool IsOpen { get; set; }

    [Parameter]
    public EventCallback<bool> IsOpenChanged { get; set; }

    [Parameter]
    public Guid ReferenceId { get; set; } = Guid.NewGuid();

    [Parameter]
    public RenderFragment? Content { get; set; }

    [Parameter]
    public RenderFragment? Footer { get; set; }

    [Parameter]
    public RenderFragment? Header { get; set; }
}
