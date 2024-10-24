﻿using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Badge : TazorBaseComponent
{
    private string GetCssClass()
    {
        switch (Type)
        {
            case BadgeType.Success:
                return Theme.Content.BadgeSuccess;
            case BadgeType.Info:
                return Theme.Content.BadgeInfo;
            case BadgeType.Warning:
                return Theme.Content.BadgeWarning;
            case BadgeType.Error:
                return Theme.Content.BadgeError;
            case BadgeType.Custom:
                return CustomClass;
            default:
                return Theme.Content.BadgeGlobal;
        }
    }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public BadgeType Type { get; set; }

    [Parameter]
    public string CustomClass { get; set; } = "";
}
