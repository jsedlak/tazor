using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

/// <summary>
/// Provides the rendering of a notification
/// </summary>
public partial class Notification : TazorBaseComponent
{
    private string GetColorClass()
    {
        return Type switch
        {
            NotificationType.Info => Theme.App.Notifications.WrapperInfo,
            NotificationType.Success => Theme.App.Notifications.WrapperSuccess,
            NotificationType.Warning => Theme.App.Notifications.WrapperWarning,
            NotificationType.Error => Theme.App.Notifications.WrapperError,
            NotificationType.Custom => Class ?? string.Empty,
            _ => Theme.App.Notifications.WrapperInfo
        };
    }

    /// <summary>
    /// Gets or Sets the icon rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Icon { get; set; }

    /// <summary>
    /// Gets or Sets the title rendering
    /// </summary>
    [Parameter]
    public RenderFragment Title { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the message rendering
    /// </summary>
    [Parameter]
    public RenderFragment Message { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the notification type
    /// </summary>
    [Parameter]
    public NotificationType Type { get; set; } = NotificationType.Info;

    /// <summary>
    /// Gets or Sets any custom CSS class
    /// </summary>
    [Parameter]
    public string? Class { get; set; } = null;

    /// <summary>
    /// Gets or Sets the backing data
    /// </summary>
    [Parameter]
    public NotificationItem? Item { get; set; } = default;

    /// <summary>
    /// Gets or Sets the callback for when the notification is closed / dismissed
    /// </summary>
    // TODO: Rename to Dismissed
    [Parameter]
    public EventCallback Closed { get; set; }
}
