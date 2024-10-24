﻿using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Button : TazorBaseComponent
{
    private async Task HandleClick()
    {
        if (Disabled)
        {
            return;
        }

        if (!string.IsNullOrWhiteSpace(Href))
        {
            Navigation.NavigateTo(Href);
        }
        else
        {
            await Clicked.InvokeAsync();
        }
    }

    private string GetWidthClass()
    {
        return Block ? "w-full" : "";
    }

    private string GetColorClass()
    {
        var classNames = new List<string>();

        if (Disabled)
        {
            classNames.Add(Theme.Button.Disabled);
        }

        switch (Type)
        {
            case ButtonType.Default:
                classNames.Add(Theme.Button.Default);
                break;
            case ButtonType.DefaultOutline:
                classNames.Add(Theme.Button.DefaultOutline);
                break;
            case ButtonType.Primary:
                classNames.Add(Theme.Button.Primary);
                break;
            case ButtonType.PrimaryOutline:
                classNames.Add(Theme.Button.PrimaryOutline);
                break;
            case ButtonType.Success:
                classNames.Add(Theme.Button.Success);
                break;
            case ButtonType.SuccessOutline:
                classNames.Add(Theme.Button.SuccessOutline);
                break;
            case ButtonType.Warning:
                classNames.Add(Theme.Button.Warning);
                break;
            case ButtonType.WarningOutline:
                classNames.Add(Theme.Button.WarningOutline);
                break;
            case ButtonType.Error:
                classNames.Add(Theme.Button.Error);
                break;
            case ButtonType.ErrorOutline:
                classNames.Add(Theme.Button.ErrorOutline);
                break;
            case ButtonType.Info:
                classNames.Add(Theme.Button.Info);
                break;
            case ButtonType.InfoOutline:
                classNames.Add(Theme.Button.InfoOutline);
                break;
            case ButtonType.Link:
                classNames.Add(Theme.Button.Link);
                break;
            default:
                classNames.Add(Theme.Button.Default);
                break;
        }

        return string.Join(" ", classNames);
    }

    [Parameter]
    public ButtonType Type { get; set; } = ButtonType.Default;

    [Parameter]
    public string? Title { get; set; } = null;

    [Parameter]
    public string? Href { get; set; } = null;

    [Parameter]
    public EventCallback Clicked { get; set; }

    [Parameter]
    public RenderFragment? Icon { get; set; } = null;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;

    [Parameter]
    public bool Block { get; set; } = false;

    [Parameter]
    public bool Disabled { get; set; }

    [Inject]
    protected NavigationManager Navigation { get; set; }
}
