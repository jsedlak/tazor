namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for utilities
/// </summary>
public class UtilityTheme
{
    /// <summary>
    /// Gets or Sets the command palette theme
    /// </summary>
    public CommandPaletteTheme CommandPalette { get; set; } = new();

    /// <summary>
    /// Gets or Sets the dark mode switch theme
    /// </summary>
    public DarkModeSwitchTheme DarkModeSwitch { get; set; } = new();
}
