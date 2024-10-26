using Microsoft.JSInterop;

namespace Tazor.Components.Utility;

/// <summary>
/// Provides javscript interop capabilities for the online status indicator
/// </summary>
public class OnlineStatusInterop : IAsyncDisposable
{
    private readonly IJSRuntime _jsRuntime;
    private DotNetObjectReference<OnlineStatusInterop> _reference;
    private bool _isInitialized;

    /// <summary>
    /// Provides change notifications for online status data
    /// </summary>
    public event EventHandler<bool>? OnlineStatusChanged;

    public OnlineStatusInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
        _reference = DotNetObjectReference.Create(this);
    }

    /// <summary>
    /// Initializes via the interop
    /// </summary>
    public async Task Initialize()
    {
        if (_isInitialized)
        {
            return;
        }

        await _jsRuntime.InvokeVoidAsync("addOnlineStatusListener", _reference);

        _isInitialized = true;
    }

    /// <summary>
    /// Used to update the status within the .NET layer from javascript
    /// </summary>
    /// <param name="isOnline"></param>
    [JSInvokable]
    public void UpdateStatus(bool isOnline)
    {
        OnlineStatusChanged?.Invoke(this, isOnline);
    }

    /// <summary>
    /// Disposes of the interop reference
    /// </summary>
    /// <returns></returns>
    public ValueTask DisposeAsync()
    {
        _reference?.Dispose();
        return ValueTask.CompletedTask;
    }
}
