﻿using Microsoft.JSInterop;

namespace Tazor.Components.Utility;

public class BreakpointInterop : IAsyncDisposable
{
    private readonly IJSRuntime _jsRuntime;
    private DotNetObjectReference<BreakpointInterop> _reference;
    private bool _isInitialized;

    public event EventHandler<BreakpointParams>? BreakpointChanged;

    public BreakpointInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
        _reference = DotNetObjectReference.Create(this);
    }

    public async Task Initialize()
    {
        if (_isInitialized)
        {
            return;
        }

        await _jsRuntime.InvokeVoidAsync("addResizeListener", _reference);

        _isInitialized = true;
    }

    [JSInvokable]
    public void BreakpointReached(BreakpointParams breakpointParams)
    {
        CurrentBreakpoint = breakpointParams.Breakpoint;
        BreakpointChanged?.Invoke(this, breakpointParams);
    }

    public ValueTask DisposeAsync()
    {
        _reference?.Dispose();
        return ValueTask.CompletedTask;
    }

    public string CurrentBreakpoint { get; private set; } = "";
}
