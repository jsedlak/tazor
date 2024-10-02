using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

public interface INotificationProvider
{
    void Add(NotificationItem notification, double durationInSeconds = 5);

    void Add(NotificationItem notification, TimeSpan duration);

    void Remove(NotificationItem notification);

    IEnumerable<NotificationItem> Notifications { get; }

    event Action<IEnumerable<NotificationItem>> NotificationsRemoved;

    event Action<IEnumerable<NotificationItem>> NotificationsAdded;
}
