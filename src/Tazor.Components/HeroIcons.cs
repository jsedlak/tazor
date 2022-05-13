using Microsoft.AspNetCore.Components;

namespace Tazor.Components;

public static class HeroIcons
{
    public static MarkupString DocumentAdd(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.HeroIcons_DocumentAdd.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    public static MarkupString ChevronRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.HeroIcons_ChevronRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    public static MarkupString ChevronLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.HeroIcons_ChevronLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    public static MarkupString ChevronUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.HeroIcons_ChevronUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    public static MarkupString ChevronDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.HeroIcons_ChevronDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    public static MarkupString Edit(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.HeroIcons_Edit.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    public static MarkupString Delete(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.HeroIcons_Delete.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }
}
