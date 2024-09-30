namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for forms components
/// </summary>
public class FormsTheme
{
    /// <summary>
    /// Gets or Sets CSS classes for the labels
    /// </summary>
    public string Label { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the sublabels
    /// </summary>
    public string SubLabel { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the textboxes
    /// </summary>
    public string TextBox { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the selects
    /// </summary>
    public string SelectInput { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the theming for the ComboBox component
    /// </summary>
    public ComboBoxTheme ComboBox { get; set; } = new();

    /// <summary>
    /// Gets or Sets theming info for the OmniBox component
    /// </summary>
    public OmniBoxTheme OmniBox { get; set; } = new();

    /// <summary>
    /// Gets or Sets theming info for the Wizard component
    /// </summary>
    public WizardTheme Wizard { get; set; } = new();
}
