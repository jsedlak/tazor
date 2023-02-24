using Microsoft.AspNetCore.Components;

namespace Tazor.Components;

public static class TazorIcons
{
    public static MarkupString TailwindSpinner(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.Tailwind_Spinner.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }
}