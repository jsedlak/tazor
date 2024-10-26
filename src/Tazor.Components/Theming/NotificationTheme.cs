namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the notification component
/// </summary>
public class NotificationTheme
{
    /// <summary>
    /// Gets or Sets the theming for the wrapper around the container
    /// </summary>
    public string ContainerWrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the container for notifications
    /// </summary>
    public string Container { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the wrapper around each notification
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the info variant
    /// </summary>
    public string WrapperInfo { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the warning variant
    /// </summary>
    public string WrapperWarning { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the error variant
    /// </summary>
    public string WrapperError { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the success variant
    /// </summary>
    public string WrapperSuccess { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the icon
    /// </summary>
    public string Icon { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the content
    /// </summary>
    public string ContentWrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the header
    /// </summary>
    public string Header { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the close icon
    /// </summary>
    public string CloseIcon { get; set;} = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the message
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for an inline container
    /// </summary>
    public string ContainerInline { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for an inline container wrapper
    /// </summary>
    public string ContainerWrapperInline { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for an empty container
    /// </summary>
    public string EmptyMessageContainer { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the message depicting no notifications are present
    /// </summary>
    public string EmptyMessage { get; set; } = string.Empty;
}
