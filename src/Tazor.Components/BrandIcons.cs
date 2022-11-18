using Microsoft.AspNetCore.Components;

namespace Tazor.Components;

public static class BrandIcons
{
    public static MarkupString Discord(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(Icons.Brands_Discord.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }
}