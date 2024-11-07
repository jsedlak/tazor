using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

/// <summary>
/// Provides a UI container for displaying notifications in a relative or static manner
/// </summary>
public partial class NotificationContainer : TazorBaseComponent
{
    /// <summary>
    /// Initializes the components
    /// </summary>
    protected override void OnInitialized()
    {
        NotificationProvider.NotificationsAdded += (_) => StateHasChanged();
        NotificationProvider.NotificationsRemoved += (_) => StateHasChanged();

        base.OnInitialized();
    }

    private string GetWrapperClass()
    {
        return Inline ? Theme.App.Notifications.ContainerWrapperInline : Theme.App.Notifications.ContainerWrapper;
    }

    private string GetContainerClass()
    {
        return Inline ? Theme.App.Notifications.ContainerInline : Theme.App.Notifications.Container;
    }

    /// <summary>
    /// Gets or Sets the provider that contains and manages notifications to be displayed
    /// </summary>
    [Inject]
    private INotificationProvider NotificationProvider { get; set; }

    /// <summary>
    /// Gets or Sets the display method for the container. Inline should display the
    /// component laid into the page between components. Setting to false should
    /// display the component and notifications globally in a static position above
    /// all components.
    /// </summary>
    [Parameter]
    public bool Inline { get; set; }

    /// <summary>
    /// Gets or Sets the message that is displayed when no notifications are present.
    /// </summary>
    [Parameter]
    public string? EmptyMessage { get; set; } = "No notifications available.";
}
