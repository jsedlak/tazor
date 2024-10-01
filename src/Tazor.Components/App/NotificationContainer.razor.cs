using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

public partial class NotificationContainer : TazorBaseComponent
{
    protected override void OnInitialized()
    {
        NotificationProvider.NotificationsAdded += (_) => StateHasChanged();
        NotificationProvider.NotificationsRemoved += (_) => StateHasChanged();

        base.OnInitialized();
    }

    private string GetWrapperClass()
    {
        if (Inline)
        {
            return Theme.App.Notifications.ContainerWrapperInline;
        }

        return Theme.App.Notifications.ContainerWrapper;
    }

    private string GetContainerClass()
    {
        if (Inline)
        {
            return Theme.App.Notifications.ContainerInline;
        }

        return Theme.App.Notifications.Container;
    }

    [Inject]
    private INotificationProvider NotificationProvider { get; set; }

    [Parameter]
    public bool Inline { get; set; }

    [Parameter]
    public string? EmptyMessage { get; set; } = "No notifications available.";
}
