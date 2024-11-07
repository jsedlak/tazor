using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

/// <summary>
/// Provides the backing data for a notification being displayed by the Notification component
/// </summary>
public class NotificationItem
{
    /// <summary>
    /// Gets or Sets the type of notification
    /// </summary>
    public NotificationType Type { get; set; }

    /// <summary>
    /// Gets or Sets the title
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or Sets the message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Gets or Sets the icon
    /// </summary>
    public MarkupString? Icon { get; set; }
}
