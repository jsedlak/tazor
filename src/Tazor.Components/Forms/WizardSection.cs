namespace Tazor.Components.Forms;

/// <summary>
/// Represents a section in a wizard
/// </summary>
public class WizardSection
{
    /// <summary>
    /// Gets or Sets the title of the section
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the order of the section in the wizard
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Progress of the section. 0 = Not started, 100 = Completed
    /// </summary>
    public int Progress { get; set; }

    /// <summary>
    /// Gets or Sets the validation status
    /// </summary>
    public ValidationSeverity Status { get; set; }
}

