using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

public partial class WizardProgress : TazorBaseComponent
{
    private string GetColor(WizardSection section)
    {
        switch (section.Status)
        {
            case ValidationSeverity.NotChecked:
                return Theme.Forms.Wizard.ProgressNotChecked;
            case ValidationSeverity.Valid:
                return Theme.Forms.Wizard.ProgressValid;
            case ValidationSeverity.Warning:
                return Theme.Forms.Wizard.ProgressWarning;
            case ValidationSeverity.Error:
                return Theme.Forms.Wizard.ProgressError;
        }

        return Theme.Forms.Wizard.ProgressNotChecked;
    }   

    [Parameter]
    public IEnumerable<WizardSection> Sections { get; set; } = [];

    [Parameter]
    public bool ShowTitles { get; set; } = false;
}
