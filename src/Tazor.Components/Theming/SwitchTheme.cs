namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the switch component
/// </summary>
public class SwitchTheme
{
    /// <summary>
    /// Gets or Sets the CSS classes for the wrapper
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the underlying track on which the knob slides
    /// </summary>
    public string Track { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes of the track when the switch is selected
    /// </summary>
    public string TrackSelected { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the knob
    /// </summary>
    public string Knob { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the knob when the switch is selected
    /// </summary>
    public string KnobSelected { get; set; } = string.Empty;
}