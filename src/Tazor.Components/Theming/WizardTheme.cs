namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the wizard components
/// </summary>
public class WizardTheme
{
    /// <summary>
    /// Gets or Sets the theming for the progress wrapper
    /// </summary>
    public string ProgressWrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the theming for the progress section wrapper
    /// </summary>
    public string ProgressSectionWrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the theming for the progress section title
    /// </summary>
    public string ProgressSectionTitle { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the progress bar background theme
    /// </summary>
    public string ProgressBarBackground { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the theming for the progress bar
    /// </summary>
    public string ProgressBar { get; set; } = string.Empty;

    public string ProgressNotChecked { get; set; } = string.Empty;

    public string ProgressValid { get; set; } = string.Empty;

    public string ProgressWarning { get; set; } = string.Empty; 

    public string ProgressError { get; set; } = string.Empty;
}