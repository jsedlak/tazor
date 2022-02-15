﻿using Microsoft.JSInterop;

namespace Tazor.Components
{
    public class OnlineStatusInterop : IAsyncDisposable
    {
        private readonly IJSRuntime _jsRuntime;
        private DotNetObjectReference<OnlineStatusInterop> _reference;
        private bool _isInitialized;

        public event EventHandler<bool>? OnlineStatusChanged;

        public OnlineStatusInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
            _reference = DotNetObjectReference.Create(this);
        }

        public async Task Initialize()
        {
            if(_isInitialized)
            {
                return;
            }

            // await _jsRuntime.InvokeVoidAsync("eval", "document.body.appendChild(Object.assign(document.createElement('script'), { src: '_content/Taozr.Components/tazor.js', type: 'text/javascript' })); ");
            await _jsRuntime.InvokeVoidAsync("addOnlineStatusListener", _reference);

            _isInitialized = true;
        }

        [JSInvokable]
        public void UpdateStatus(bool isOnline)
        {
            OnlineStatusChanged?.Invoke(this, isOnline);
        }

        public ValueTask DisposeAsync()
        {
            _reference?.Dispose();
            return ValueTask.CompletedTask;
        }
    }
}