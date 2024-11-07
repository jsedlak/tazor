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
    
    /// <summary>
    /// Gets or Sets panel theming
    /// </summary>
    public string Panel { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the global alert theming
    /// </summary>
    public string AlertGlobal { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the info alert theming
    /// </summary>
    public string AlertInfo { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the warning alert theming
    /// </summary>
    public string AlertWarning { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the error alert theming
    /// </summary>
    public string AlertError { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the success alert theming
    /// </summary>
    public string AlertSuccess { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the alert icon theming
    /// </summary>
    public string AlertIcon { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets icon theming
    /// </summary>
    [Obsolete]
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

    /// <summary>
    /// Gets or Sets theming for the paragraph component
    /// </summary>
    public string Paragraph { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets header 1 theming
    /// </summary>
    public string Header1 { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets header 2 theming
    /// </summary>
    public string Header2 { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or Sets header 3 theming
    /// </summary>
    public string Header3 { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or Sets header 4 theming
    /// </summary>
    public string Header4 { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets global badge theming
    /// </summary>
    public string BadgeGlobal { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets info badge theming
    /// </summary>
    public string BadgeInfo { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets warning badge theming
    /// </summary>
    public string BadgeWarning { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets success badge theming
    /// </summary>
    public string BadgeSuccess { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets error badge theming
    /// </summary>
    public string BadgeError { get; set; } = string.Empty;
}
