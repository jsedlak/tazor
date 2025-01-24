using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Layout;

/// <summary>
/// Provides a dialog/modal implementation using the native <dialog> element</dialog>
/// </summary>
public partial class Dialog : DialogBase
{
    private readonly IJSRuntime _jsRuntime;
    
    public Dialog(IJSRuntime jsRuntime)
        : base(jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    [Parameter]
    public bool HideCloseButton { get; set; }
}
