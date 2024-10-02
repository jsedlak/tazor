namespace Tazor.Components.App;

internal class NotificationTimeout
{
    public NotificationItem Notification { get; set; }

    public DateTimeOffset TimeOut { get; set; } 

    public DateTimeOffset Added { get; set; }
}