using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

/// <summary>
/// Provides a centralized store for notifications
/// </summary>
public interface INotificationProvider
{
    /// <summary>
    /// Adds a notification with a timeout
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="durationInSeconds"></param>
    void Add(NotificationItem notification, double durationInSeconds = 5);

    /// <summary>
    /// Adds a notification with a timeout
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="duration"></param>
    void Add(NotificationItem notification, TimeSpan duration);

    /// <summary>
    /// Removes a timeout
    /// </summary>
    /// <param name="notification"></param>
    void Remove(NotificationItem notification);

    /// <summary>
    /// Gets the current list of notifications
    /// </summary>
    IEnumerable<NotificationItem> Notifications { get; }

    /// <summary>
    /// Notifies when notifications have been removed
    /// </summary>
    event Action<IEnumerable<NotificationItem>> NotificationsRemoved;

    /// <summary>
    /// Notifies when notifications have been added
    /// </summary>
    event Action<IEnumerable<NotificationItem>> NotificationsAdded;
}
