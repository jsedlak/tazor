namespace Tazor.Components.App;

/// <summary>
/// Provides the type of notification to display.
/// </summary>
public enum NotificationType
{
    /// <summary>
    /// An informational notification.
    /// </summary>
    Info,

    /// <summary>
    /// A warning notification.
    /// </summary>
    Warning,

    /// <summary>
    /// A notification indicating success.
    /// </summary>
    Success,

    /// <summary>
    /// An error notification.
    /// </summary>
    Error,

    /// <summary>
    /// A custom notification.
    /// </summary>
    Custom
}
