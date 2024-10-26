namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the App Components
/// </summary>
public class AppTheme
{
    /// <summary>
    /// Gets or Sets theming for avatars
    /// </summary>
    public AvatarTheme Avatar { get; set; } = new();

    /// <summary>
    /// Gets or Sets theming for notifications
    /// </summary>
    public NotificationTheme Notifications { get; set; } = new();

    /// <summary>
    /// Gets or Sets theming for stat cards
    /// </summary>
    public StatCardTheme StatCard { get; set; } = new();

    /// <summary>
    /// Gets or Sets theming for the ping notification
    /// </summary>
    public PingTheme Ping { get; set; } = new();

    /// <summary>
    /// Gets or Sets the command palette theme
    /// </summary>
    public CommandPaletteTheme CommandPalette { get; set; } = new();
}
