using Microsoft.JSInterop;

namespace Tazor.Components.Utility;

/// <summary>
/// Provides interop capabilities for the breakpoint indicator
/// </summary>
public class BreakpointInterop : IAsyncDisposable
{
    private readonly IJSRuntime _jsRuntime;
    private DotNetObjectReference<BreakpointInterop> _reference;
    private bool _isInitialized;

    /// <summary>
    /// Notifies when a breakpoint has been reached
    /// </summary>
    public event EventHandler<BreakpointParams>? BreakpointChanged;

    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="jsRuntime"></param>
    public BreakpointInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
        _reference = DotNetObjectReference.Create(this);
    }

    /// <summary>
    /// Initializes the interop, setting defaults based on current data
    /// </summary>
    public async Task Initialize()
    {
        if (_isInitialized)
        {
            return;
        }

        await _jsRuntime.InvokeVoidAsync("addResizeListener", _reference);

        _isInitialized = true;
    }

    /// <summary>
    /// Invoked by javascript to notify that a breakpoint has been reached
    /// </summary>
    /// <param name="breakpointParams"></param>
    [JSInvokable]
    public void BreakpointReached(BreakpointParams breakpointParams)
    {
        CurrentBreakpoint = breakpointParams.Breakpoint;
        BreakpointChanged?.Invoke(this, breakpointParams);
    }

    /// <summary>
    /// Disposes of the breakpoint interop object
    /// </summary>
    /// <returns></returns>
    public ValueTask DisposeAsync()
    {
        _reference?.Dispose();
        return ValueTask.CompletedTask;
    }

    /// <summary>
    /// Gets the current breakpoint
    /// </summary>
    public string CurrentBreakpoint { get; private set; } = "";
}
