window.addOnlineStatusListener = function (dotNetRef) {
    function updateDotNet() {
        dotNetRef.invokeMethodAsync('UpdateStatus', navigator.onLine);
    };

    window.addEventListener('online', updateDotNet);
    window.addEventListener('offline', updateDotNet);

    updateDotNet();
}