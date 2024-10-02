using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

public partial class Notification : TazorBaseComponent
{
    private string GetColorClass()
    {
        switch (Type)
        {
            case NotificationType.Info:
                return Theme.App.Notifications.WrapperInfo;
            case NotificationType.Success:
                return Theme.App.Notifications.WrapperSuccess;
            case NotificationType.Warning:
                return Theme.App.Notifications.WrapperWarning;
            case NotificationType.Error:
                return Theme.App.Notifications.WrapperError;
            case NotificationType.Custom:
                return Class ?? string.Empty;
        }

        return Theme.App.Notifications.WrapperInfo;
    }

    [Parameter]
    public RenderFragment? Icon { get; set; }

    [Parameter]
    public RenderFragment Title { get; set; } = null!;

    [Parameter]
    public RenderFragment Message { get; set; } = null!;

    [Parameter]
    public NotificationType Type { get; set; } = NotificationType.Info;

    [Parameter]
    public string? Class { get; set; } = null;

    [Parameter]
    public NotificationItem? Item { get; set; } = default;

    [Parameter]
    public EventCallback Closed { get; set; }
}
