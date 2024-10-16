namespace Tazor.Components.Theming;

public class AppTheme
{
    public AvatarTheme Avatar { get; set; } = new();

    public NotificationTheme Notifications { get; set; } = new();

    public StatCardTheme StatCard { get; set; } = new();

    public PingTheme Ping { get; set; } = new();
}
