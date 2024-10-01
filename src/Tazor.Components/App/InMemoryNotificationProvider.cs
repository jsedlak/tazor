namespace Tazor.Components.App;

public class InMemoryNotificationProvider : INotificationProvider, IDisposable
{
    private List<NotificationTimeout> _timeouts = new();
    private readonly Timer _timer;

    public event Action<IEnumerable<NotificationItem>> NotificationsRemoved;
    public event Action<IEnumerable<NotificationItem>> NotificationsAdded;

    public InMemoryNotificationProvider()
    {
        _timer = new Timer(OnTimerTicked, null, 1000, 1000);
    }

    ~InMemoryNotificationProvider()
    {
        Dispose(false);
    }

    private void OnTimerTicked(object? state)
    {
        var expired = _timeouts.Where(t => t.TimeOut <= DateTimeOffset.Now);
        var expiredNotifications = expired.Select(m => m.Notification);

        _timeouts = _timeouts.Except(expired).ToList();
        Notifications = Notifications.Except(expiredNotifications);

        NotificationsRemoved.Invoke(expiredNotifications);
    }

    public void Add(NotificationItem notification, double durationInSeconds = 5)
    {
        Add(notification, TimeSpan.FromSeconds(durationInSeconds));
    }

    public void Add(NotificationItem notification, TimeSpan duration)
    {

        var newTimeout = new NotificationTimeout
        {
            Added = DateTimeOffset.Now,
            TimeOut = duration.TotalSeconds <= 0 ? DateTimeOffset.MaxValue : DateTimeOffset.Now + duration,
            Notification = notification
        };

        _timeouts.Add(newTimeout);
        Notifications = Notifications.Append(notification);

        NotificationsAdded?.Invoke([notification]);
    }

    public void Remove(NotificationItem notification)
    {
        var timeout = _timeouts.FirstOrDefault(t => t.Notification == notification);
        if (timeout != null)
        {
            _timeouts.Remove(timeout);
            Notifications = Notifications.Except([notification]);
            NotificationsRemoved?.Invoke([notification]);
        }
    }

    public void Dispose()
    {
        Dispose(true);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (IsDisposed)
        {
            return;
        }

        if(disposing)
        {
            GC.SuppressFinalize(this);
        }

        _timer.Dispose();
        IsDisposed = true;
    }

    public bool IsDisposed { get; private set; }

    public IEnumerable<NotificationItem> Notifications { get; private set; } = [];
}