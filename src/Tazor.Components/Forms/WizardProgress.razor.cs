using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

/// <summary>
/// Renders a group of components representing a stepped process
/// </summary>
public partial class WizardProgress : TazorBaseComponent
{
    private string GetColor(WizardSection section)
    {
        return section.Status switch
        {
            ValidationSeverity.NotChecked => Theme.Forms.Wizard.ProgressNotChecked,
            ValidationSeverity.Valid => Theme.Forms.Wizard.ProgressValid,
            ValidationSeverity.Warning => Theme.Forms.Wizard.ProgressWarning,
            ValidationSeverity.Error => Theme.Forms.Wizard.ProgressError,
            _ => Theme.Forms.Wizard.ProgressNotChecked
        };
    }   

    /// <summary>
    /// Gets or Sets the sections to render
    /// </summary>
    [Parameter]
    public IEnumerable<WizardSection> Sections { get; set; } = [];

    /// <summary>
    /// Gets or Sets whether titles should be displayed
    /// </summary>
    [Parameter]
    public bool ShowTitles { get; set; } = false;
}
