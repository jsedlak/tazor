namespace Tazor.Components.App;

/// <summary>
/// Defines a notification timeout for maintaining an up-to-date list of notifications
/// </summary>
internal class NotificationTimeout
{
    internal NotificationItem Notification { get; set; } = null!;

    internal DateTimeOffset TimeOut { get; set; } 

    internal DateTimeOffset Added { get; set; }
}