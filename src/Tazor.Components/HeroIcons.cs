using Microsoft.AspNetCore.Components;

namespace Tazor.Components;

/// <summary>
/// Provides standard set of hero icons as markup strings
/// </summary>
public static class HeroIcons
{
    /// <summary>
    /// Returns the academic cap icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString AcademicCap(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.AcademicCap.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the adjustments horizontal icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString AdjustmentsHorizontal(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.AdjustmentsHorizontal.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the adjustments vertical icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString AdjustmentsVertical(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.AdjustmentsVertical.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the archive box arrow down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArchiveBoxArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArchiveBoxArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the archive box x mark icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArchiveBoxXMark(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArchiveBoxXMark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the archive box icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArchiveBox(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArchiveBox.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow down circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowDownCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowDownCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow down left circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowDownLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowDownLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow down on square stack icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowDownOnSquareStack(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowDownOnSquareStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow down on square icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowDownOnSquare(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowDownOnSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow down right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowDownRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowDownRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow down tray icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowDownTray(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowDownTray.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow left circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowLeftCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowLeftCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow left on rectangle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowLeftOnRectangle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowLeftOnRectangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow long down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowLongDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowLongDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow long left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowLongLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowLongLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow long right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowLongRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowLongRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow long up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowLongUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowLongUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow path rounded square icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowPathRoundedSquare(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowPathRoundedSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow path icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowPath(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowPath.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow right circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowRightCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowRightCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow right on rectangle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowRightOnRectangle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowRightOnRectangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow small down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowSmallDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowSmallDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow small left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowSmallLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowSmallLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow small right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowSmallRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowSmallRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow small up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowSmallUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowSmallUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow top right on square icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowTopRightOnSquare(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowTopRightOnSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow trending down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowTrendingDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowTrendingDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow trending up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowTrendingUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowTrendingUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow up circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUpCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUpCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow up left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUpLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUpLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow up on square stack icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUpOnSquareStack(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUpOnSquareStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow up on square icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUpOnSquare(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUpOnSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow up right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUpRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUpRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow up tray icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUpTray(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUpTray.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow uturn down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUturnDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUturnDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow uturn left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUturnLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUturnLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow uturn right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUturnRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUturnRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrow uturn up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowUturnUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowUturnUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrows pointing in icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowsPointingIn(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowsPointingIn.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrows pointing out icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowsPointingOut(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowsPointingOut.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrows right left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowsRightLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowsRightLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the arrows up down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ArrowsUpDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ArrowsUpDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the at symbol icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString AtSymbol(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.AtSymbol.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the backspace icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Backspace(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Backspace.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the backward icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Backward(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Backward.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the banknotes icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Banknotes(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Banknotes.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the two bars icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bars2(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bars2.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the 3 bars bottom left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bars3BottomLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bars3BottomLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the 3 bars bottom right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bars3BottomRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bars3BottomRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the 3 bars center left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bars3CenterLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bars3CenterLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the 3 bars icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bars3(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bars3.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the 4 bars icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bars4(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bars4.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bars arrow down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BarsArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BarsArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bars arrow up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BarsArrowUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BarsArrowUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }
    
    /// <summary>
    /// Returns the battery 0% icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Battery0(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Battery0.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the battery 100% icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Battery100(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Battery100.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the battery 50% icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Battery50(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Battery50.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the beaker icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Beaker(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Beaker.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bell alert icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BellAlert(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BellAlert.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bell slash icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BellSlash(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BellSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bell snooze icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BellSnooze(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BellSnooze.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bell icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bell(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bell.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bolt slash icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BoltSlash(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BoltSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bolt icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bolt(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bolt.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the book open icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BookOpen(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BookOpen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bookmark slash icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BookmarkSlash(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BookmarkSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bookmark square icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BookmarkSquare(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BookmarkSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bookmark icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Bookmark(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Bookmark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the briefcase icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Briefcase(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Briefcase.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bug ant icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BugAnt(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BugAnt.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the library icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BuildingLibrary(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BuildingLibrary.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the office 2 icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BuildingOffice2(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BuildingOffice2.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the office icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BuildingOffice(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BuildingOffice.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the storefront icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString BuildingStorefront(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.BuildingStorefront.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cake icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Cake(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Cake.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the calculator icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Calculator(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Calculator.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the calendar days icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CalendarDays(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CalendarDays.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the calendar icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Calendar(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Calendar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the camera icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Camera(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Camera.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bar chart square icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChartBarSquare(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChartBarSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bar chart icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChartBar(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChartBar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the pie chart icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChartPie(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChartPie.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chat bubble bottom center text icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChatBubbleBottomCenterText(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChatBubbleBottomCenterText.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chat bubble bottom center icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChatBubbleBottomCenter(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChatBubbleBottomCenter.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bubble left ellipsis icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChatBubbleLeftEllipsis(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChatBubbleLeftEllipsis.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chat bubble left right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChatBubbleLeftRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChatBubbleLeftRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chat bubble left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChatBubbleLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChatBubbleLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chat bubble oval left ellipsis icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChatBubbleOvalLeftEllipsis(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChatBubbleOvalLeftEllipsis.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chat bubble oval left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChatBubbleOvalLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChatBubbleOvalLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the check badge icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CheckBadge(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CheckBadge.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the check circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CheckCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CheckCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the check icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Check(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Check.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron double down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronDoubleDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronDoubleDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron double right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronDoubleLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronDoubleLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron double right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronDoubleRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronDoubleRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron double up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronDoubleUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronDoubleUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron up down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronUpDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronUpDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the chevron up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ChevronUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ChevronUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the circle stack icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CircleStack(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CircleStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the clipboard document check icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ClipboardDocumentCheck(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ClipboardDocumentCheck.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the clipboard document list icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ClipboardDocumentList(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ClipboardDocumentList.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the clipboard document icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ClipboardDocument(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ClipboardDocument.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the clipboard list icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Clipboard(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Clipboard.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the clock icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Clock(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Clock.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cloud arrow down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CloudArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CloudArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cloud arrow up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CloudArrowUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CloudArrowUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cloud icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Cloud(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Cloud.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the code bracket square icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CodeBracketSquare(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CodeBracketSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the code bracket icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CodeBracket(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CodeBracket.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the 6 tooth cog icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Cog6Tooth(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Cog6Tooth.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the 8 tooth cog icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Cog8Tooth(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Cog8Tooth.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cog icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Cog(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Cog.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the command line icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CommandLine(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CommandLine.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the computer desktop icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ComputerDesktop(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ComputerDesktop.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cpu icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CpuChip(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CpuChip.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the credit card icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CreditCard(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CreditCard.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cube transparent icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CubeTransparent(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CubeTransparent.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cube icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Cube(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Cube.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the currency bangladeshi icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CurrencyBangladeshi(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CurrencyBangladeshi.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the currency dollar icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CurrencyDollar(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CurrencyDollar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the currency euro icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CurrencyEuro(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CurrencyEuro.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the currency pound icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CurrencyPound(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CurrencyPound.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the currency rupee icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CurrencyRupee(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CurrencyRupee.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the currency yen icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CurrencyYen(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CurrencyYen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cursor arrow rays icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CursorArrowRays(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CursorArrowRays.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cursor arrow ripple icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString CursorArrowRipple(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.CursorArrowRipple.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the cell phone icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DevicePhoneMobile(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DevicePhoneMobile.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the table icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DeviceTablet(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DeviceTablet.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the document arrow down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the document arrow up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentArrowUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentArrowUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the bar chart document icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentChartBar(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentChartBar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the document check icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentCheck(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentCheck.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the document duplicate icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentDuplicate(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentDuplicate.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the search document icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentMagnifyingGlass(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentMagnifyingGlass.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the document delete icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentMinus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentMinus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the add document icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentPlus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the text document icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString DocumentText(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.DocumentText.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the document icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Document(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Document.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the ellipsis horizontal circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString EllipsisHorizontalCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.EllipsisHorizontalCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the ellipsis horizontal icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString EllipsisHorizontal(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.EllipsisHorizontal.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the ellipsis vertical icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString EllipsisVertical(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.EllipsisVertical.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the envelope open icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString EnvelopeOpen(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.EnvelopeOpen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the envelope icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Envelope(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Envelope.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the exclamation circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ExclamationCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ExclamationCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the exclamation triangle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ExclamationTriangle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ExclamationTriangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the eye dropper icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString EyeDropper(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.EyeDropper.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the eye slash icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString EyeSlash(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.EyeSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the eye icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Eye(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Eye.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the frowny face icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString FaceFrown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.FaceFrown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the smiley face icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString FaceSmile(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.FaceSmile.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the film icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Film(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Film.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the finger print icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString FingerPrint(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.FingerPrint.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the fire icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Fire(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Fire.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the flag icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Flag(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Flag.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the folder arrow down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString FolderArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.FolderArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the delete folder icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString FolderMinus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.FolderMinus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the open folder icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString FolderOpen(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.FolderOpen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the add folder icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString FolderPlus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.FolderPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the search folder icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Folder(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Folder.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the forward icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Forward(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Forward.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the funnel/filter icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Funnel(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Funnel.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the gif icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Gif(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Gif.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the gift top icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString GiftTop(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.GiftTop.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the gift icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Gift(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Gift.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the globe alternate icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString GlobeAlt(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.GlobeAlt.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the globe americas icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString GlobeAmericas(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.GlobeAmericas.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the globe asia australia icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString GlobeAsiaAustralia(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.GlobeAsiaAustralia.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the globe europe africa icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString GlobeEuropeAfrica(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.GlobeEuropeAfrica.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the hand raised icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString HandRaised(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.HandRaised.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the hand thumb down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString HandThumbDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.HandThumbDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the hand thumb up icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString HandThumbUp(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.HandThumbUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the hashtag icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Hashtag(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Hashtag.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the heart icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Heart(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Heart.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the modern home icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString HomeModern(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.HomeModern.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the home icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Home(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Home.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the identification icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Identification(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Identification.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the inbox arrow down icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString InboxArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.InboxArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the inbox arrow stack icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString InboxStack(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.InboxStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the inbox icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Inbox(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Inbox.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the information circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString InformationCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.InformationCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the key icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Key(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Key.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the language icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Language(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Language.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the lifebuoy icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Lifebuoy(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Lifebuoy.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the light bulb icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString LightBulb(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.LightBulb.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the link icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Link(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Link.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the list bullet icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ListBullet(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ListBullet.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the lock closed icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString LockClosed(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.LockClosed.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the lock open icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString LockOpen(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.LockOpen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the magnifying glass circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString MagnifyingGlassCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.MagnifyingGlassCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the magnifying glass minus icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString MagnifyingGlassMinus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.MagnifyingGlassMinus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the magnifying glass plus icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString MagnifyingGlassPlus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.MagnifyingGlassPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the magnifying glass icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString MagnifyingGlass(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.MagnifyingGlass.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the map pin icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString MapPin(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.MapPin.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the map icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Map(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Map.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the megaphone icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Megaphone(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Megaphone.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the microphone icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Microphone(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Microphone.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the minus circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString MinusCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.MinusCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the minus small icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString MinusSmall(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.MinusSmall.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the minus icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Minus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Minus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the moon icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Moon(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Moon.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the music note icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString MusicalNote(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.MusicalNote.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the newspaper icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Newspaper(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Newspaper.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the no symbol icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString NoSymbol(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.NoSymbol.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the paint brush icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PaintBrush(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PaintBrush.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the paper airplane icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PaperAirplane(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PaperAirplane.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the paper clip icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PaperClip(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PaperClip.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the pause circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PauseCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PauseCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the pause icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Pause(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Pause.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the pencil square icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PencilSquare(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PencilSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the pencil icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Pencil(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Pencil.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the phone arrow down left icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PhoneArrowDownLeft(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PhoneArrowDownLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the phone arrow up right icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PhoneArrowUpRight(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PhoneArrowUpRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the phone x mark icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PhoneXMark(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PhoneXMark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the phone icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Phone(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Phone.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the photo icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Photo(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Photo.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the play circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PlayCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PlayCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the play pause icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PlayPause(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PlayPause.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the play icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Play(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Play.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the plus circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PlusCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PlusCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the plus small icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PlusSmall(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PlusSmall.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the plus icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Plus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Plus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the power icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Power(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Power.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the presentation bar chart icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PresentationChartBar(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PresentationChartBar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the presentation line chart icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PresentationChartLine(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PresentationChartLine.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the printer icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Printer(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Printer.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the puzzle piece icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString PuzzlePiece(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.PuzzlePiece.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the QR code icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString QrCode(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.QrCode.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the question mark circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString QuestionMarkCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.QuestionMarkCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the queue list icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString QueueList(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.QueueList.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the radio icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Radio(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Radio.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Retruns the receipt percent icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ReceiptPercent(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ReceiptPercent.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the receipt refund
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ReceiptRefund(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ReceiptRefund.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the rectangle group icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString RectangleGroup(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.RectangleGroup.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the rectangle stack icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString RectangleStack(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.RectangleStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the rocket launch icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString RocketLaunch(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.RocketLaunch.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the rss icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Rss(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Rss.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the scale icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Scale(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Scale.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the scissors icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Scissors(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Scissors.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the server stack icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ServerStack(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ServerStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the server icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Server(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Server.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the share icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Share(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Share.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the shield check icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ShieldCheck(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ShieldCheck.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the shield exclamation icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ShieldExclamation(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ShieldExclamation.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the shopping bag icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ShoppingBag(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ShoppingBag.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the shopping cart icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ShoppingCart(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ShoppingCart.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the signal slash icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString SignalSlash(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.SignalSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the signal icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Signal(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Signal.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the sparkles icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Sparkles(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Sparkles.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the speaker wave icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString SpeakerWave(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.SpeakerWave.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the speaker x mark icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString SpeakerXMark(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.SpeakerXMark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the square 2 stack icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Square2Stack(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Square2Stack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the square 3 stack 3D icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Square3Stack3D(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Square3Stack3D.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the squares 2x2 icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Squares2X2(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Squares2X2.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the squares plus icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString SquaresPlus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.SquaresPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the star icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Star(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Star.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the stop circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString StopCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.StopCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the stop icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Stop(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Stop.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the sun icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Sun(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Sun.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the swatch icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Swatch(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Swatch.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the table cells icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString TableCells(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.TableCells.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the tag icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Tag(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Tag.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the ticket icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Ticket(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Ticket.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the trash icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Trash(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Trash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the trophy icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Trophy(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Trophy.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the truck icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Truck(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Truck.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the tv icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Tv(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Tv.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the user circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString UserCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.UserCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the user group icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString UserGroup(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.UserGroup.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the user minus icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString UserMinus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.UserMinus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the user plus icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString UserPlus(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.UserPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the user icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString User(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.User.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the users icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Users(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Users.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the variable icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Variable(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Variable.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the video camera slash icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString VideoCameraSlash(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.VideoCameraSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the video camera icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString VideoCamera(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.VideoCamera.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the view columns icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ViewColumns(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ViewColumns.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the viewfinder circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString ViewfinderCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.ViewfinderCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the wallet icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Wallet(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Wallet.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the wifi icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Wifi(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Wifi.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the window icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Window(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Window.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the wrench screwdriver icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString WrenchScrewdriver(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.WrenchScrewdriver.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the wrench icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString Wrench(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.Wrench.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the x circle icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString XCircle(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.XCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the x mark icon
    /// </summary>
    /// <param name="cssClass"></param>
    /// <param name="widthAndHeight"></param>
    /// <returns></returns>
    public static MarkupString XMark(string cssClass = "", string widthAndHeight = "w-5 h-5")
    {
        return new MarkupString(HeroIconsOutlineResources.XMark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }
}
