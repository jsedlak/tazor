using Microsoft.AspNetCore.Components;

namespace Tazor.Components.App;

public partial class NotificationItem
{
    public NotificationType Type { get; set; }

    public string? Title { get; set; }

    public string? Message { get; set; }

    public MarkupString? Icon { get; set; }
}
