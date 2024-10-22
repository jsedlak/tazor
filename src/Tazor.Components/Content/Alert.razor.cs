using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Alert : TazorBaseComponent
{
    private string _cssClass { get; set; } = "";

    protected override void OnInitialized()
    {
        if (Type == AlertType.Custom)
        {
            _cssClass = $"{Theme.Content.AlertGlobal} {Class ?? string.Empty}";
        }
        else
        {
            var alertClass = "";
            switch (Type)
            {
                case AlertType.Success:
                    alertClass = Theme.Content.AlertSuccess;
                    break;
                case AlertType.Error:
                    alertClass = Theme.Content.AlertError;
                    break;
                case AlertType.Warning:
                    alertClass = Theme.Content.AlertWarning;
                    break;
                case AlertType.Info:
                    alertClass = Theme.Content.AlertInfo;
                    break;
            }
            _cssClass = $"{Theme.Content.AlertGlobal} {alertClass} {Class ?? string.Empty}";
        }
    }

    [Parameter]
    public string? Title { get; set; } = null;

    [Parameter]
    public RenderFragment? Icon { get; set; } = null;

    [Parameter]
    public RenderFragment? Content { get; set; } = null;

    [Parameter]
    public RenderFragment? LinkContent { get; set; } = null;

    [Parameter]
    public AlertType Type { get; set; } = AlertType.Info;

    [Parameter]
    public string? Class { get; set; }
}
