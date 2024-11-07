namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for layout components
/// </summary>
public class LayoutTheme
{
    /// <summary>
    /// Gets or Sets accordion theming
    /// </summary>
    public AccordionTheme Accordion { get; set; } = new();

    /// <summary>
    /// Gets or Sets overlay theming
    /// </summary>
    public OverlayTheme Overlay { get; set; } = new();
}
