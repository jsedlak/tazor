namespace Tazor.Components.App;

/// <summary>
/// Provides notifications from a memory store
/// </summary>
public sealed class InMemoryNotificationProvider : INotificationProvider, IDisposable
{
    private List<NotificationTimeout> _timeouts = new();
    private readonly Timer _timer;

    /// <summary>
    /// Notifies when notifications have been removed
    /// </summary>
    public event Action<IEnumerable<NotificationItem>> NotificationsRemoved;
    
    /// <summary>
    /// Notifies when notifications have been added
    /// </summary>
    public event Action<IEnumerable<NotificationItem>> NotificationsAdded;
    
    /// <summary>
    /// Constructor
    /// </summary>
    public InMemoryNotificationProvider()
    {
        // Defaults
        NotificationsRemoved = (_) => { };
        NotificationsAdded = (_) => { };
        
        _timer = new Timer(OnTimerTicked, null, 1000, 1000);
    }

    /// <summary>
    /// Deconstructor
    /// </summary>
    ~InMemoryNotificationProvider()
    {
        Dispose(false);
    }

    private void OnTimerTicked(object? state)
    {
        var expired = _timeouts.Where(t => t.TimeOut <= DateTimeOffset.Now).ToArray();
        var expiredNotifications = expired.Select(m => m.Notification).ToArray();

        _timeouts = _timeouts.Except(expired).ToList();
        Notifications = Notifications.Except(expiredNotifications);

        NotificationsRemoved.Invoke(expiredNotifications);
    }

    /// <summary>
    /// Adds a notification with a timeout
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="durationInSeconds"></param>
    public void Add(NotificationItem notification, double durationInSeconds = 5)
    {
        Add(notification, TimeSpan.FromSeconds(durationInSeconds));
    }

    /// <summary>
    /// Adds a notification with a timeout
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="duration"></param>
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

    /// <summary>
    /// Removes a timeout
    /// </summary>
    /// <param name="notification"></param>
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

    /// <summary>
    /// Disposes of the provider
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
    }

    private void Dispose(bool disposing)
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

    /// <summary>
    /// Gets whether the provider has been disposed
    /// </summary>
    public bool IsDisposed { get; private set; }

    /// <summary>
    /// Gets the current list of notifications
    /// </summary>
    public IEnumerable<NotificationItem> Notifications { get; private set; } = [];
}
