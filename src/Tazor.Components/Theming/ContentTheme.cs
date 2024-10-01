namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for content
/// </summary>
public class ContentTheme
{
    /// <summary>
    /// Gets or Sets the spinner theme
    /// </summary>
    public SpinnerTheme Spinner { get; set; } = new();

    public string ScreenReader { get; set; } = string.Empty;

    public string ComponentHeader { get; set; } = string.Empty;

    public string Panel { get; set; } = string.Empty;

    public string Button { get; set; } = string.Empty;

    public string ButtonInner { get; set; } = string.Empty;

    public string AlertGlobal { get; set; } = string.Empty;

    public string AlertInfo { get; set; } = string.Empty;

    public string AlertWarning { get; set; } = string.Empty;

    public string AlertError { get; set; } = string.Empty;

    public string AlertSuccess { get; set; } = string.Empty;

    public string AlertIcon { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the code block theme
    /// </summary>
    public CodeBlockTheme CodeBlock { get; set; } = new();

    /// <summary>
    /// Gets or Sets the popover theme
    /// </summary>
    public PopoverTheme Popover { get; set; } = new();

    /// <summary>
    /// Gets or Sets the CSS classes for the section element
    /// </summary>
    public string Section { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the css classes for the lead component
    /// </summary>
    public string Lead { get; set; } = string.Empty;

    public string Paragraph { get; set; } = string.Empty;

    public string Header1 { get; set; } = string.Empty;

    public string Header2 { get; set; } = string.Empty;
    
    public string Header3 { get; set; } = string.Empty;
    
    public string Header4 { get; set; } = string.Empty;

    public string BadgeGlobal { get; set; } = string.Empty;

    public string BadgeInfo { get; set; } = string.Empty;

    public string BadgeWarning { get; set; } = string.Empty;

    public string BadgeSuccess { get; set; } = string.Empty;

    public string BadgeError { get; set; } = string.Empty;
}
