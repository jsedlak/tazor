using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Provides the all versions of the Hero Icons Library 
/// </summary>
public static class HeroIcons
{
    /// <summary>
    /// Returns the Academic Cap icon
    /// </summary>
    public static MarkupString AcademicCap(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.AcademicCap(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.AcademicCap(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.AcademicCap(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.AcademicCap.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Adjustments Horizontal icon
    /// </summary>
    public static MarkupString AdjustmentsHorizontal(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.AdjustmentsHorizontal(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.AdjustmentsHorizontal(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.AdjustmentsHorizontal(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.AdjustmentsHorizontal.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Adjustments Vertical icon
    /// </summary>
    public static MarkupString AdjustmentsVertical(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.AdjustmentsVertical(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.AdjustmentsVertical(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.AdjustmentsVertical(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.AdjustmentsVertical.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Archive Box Arrow Down icon
    /// </summary>
    public static MarkupString ArchiveBoxArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArchiveBoxArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArchiveBoxArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArchiveBoxArrowDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArchiveBoxArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Archive Box X Mark icon
    /// </summary>
    public static MarkupString ArchiveBoxXMark(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArchiveBoxXMark(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArchiveBoxXMark(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArchiveBoxXMark(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArchiveBoxXMark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Archive Box icon
    /// </summary>
    public static MarkupString ArchiveBox(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArchiveBox(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArchiveBox(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArchiveBox(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArchiveBox.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Down Circle icon
    /// </summary>
    public static MarkupString ArrowDownCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowDownCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowDownCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowDownCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowDownCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Down Left icon
    /// </summary>
    public static MarkupString ArrowDownLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowDownLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowDownLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowDownLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowDownLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Down On Square Stack icon
    /// </summary>
    public static MarkupString ArrowDownOnSquareStack(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowDownOnSquareStack(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowDownOnSquareStack(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowDownOnSquareStack(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowDownOnSquareStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Down On Square icon
    /// </summary>
    public static MarkupString ArrowDownOnSquare(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowDownOnSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowDownOnSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowDownOnSquare(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowDownOnSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Down Right icon
    /// </summary>
    public static MarkupString ArrowDownRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowDownRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowDownRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowDownRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowDownRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Down Tray icon
    /// </summary>
    public static MarkupString ArrowDownTray(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowDownTray(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowDownTray(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowDownTray(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowDownTray.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Down icon
    /// </summary>
    public static MarkupString ArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Left Circle icon
    /// </summary>
    public static MarkupString ArrowLeftCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLeftCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowLeftCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLeftCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLeftCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Left End On Rectangle icon
    /// </summary>
    public static MarkupString ArrowLeftEndOnRectangle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLeftEndOnRectangle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowLeftEndOnRectangle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLeftEndOnRectangle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLeftEndOnRectangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Left On Rectangle icon
    /// </summary>
    public static MarkupString ArrowLeftOnRectangle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLeftOnRectangle(cssClass, widthAndHeight);

            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLeftOnRectangle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLeftOnRectangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Left Start On Rectangle icon
    /// </summary>
    public static MarkupString ArrowLeftStartOnRectangle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLeftStartOnRectangle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowLeftStartOnRectangle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLeftStartOnRectangle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLeftStartOnRectangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Left icon
    /// </summary>
    public static MarkupString ArrowLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Long Down icon
    /// </summary>
    public static MarkupString ArrowLongDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLongDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowLongDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLongDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLongDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Long Left icon
    /// </summary>
    public static MarkupString ArrowLongLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLongLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowLongLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLongLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLongLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Long Right icon
    /// </summary>
    public static MarkupString ArrowLongRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLongRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowLongRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLongRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLongRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Long Up icon
    /// </summary>
    public static MarkupString ArrowLongUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowLongUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowLongUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowLongUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowLongUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Path Rounded Square icon
    /// </summary>
    public static MarkupString ArrowPathRoundedSquare(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowPathRoundedSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowPathRoundedSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowPathRoundedSquare(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowPathRoundedSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Path icon
    /// </summary>
    public static MarkupString ArrowPath(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowPath(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowPath(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowPath(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowPath.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Right Circle icon
    /// </summary>
    public static MarkupString ArrowRightCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowRightCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowRightCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowRightCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowRightCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Right End On Rectangle icon
    /// </summary>
    public static MarkupString ArrowRightEndOnRectangle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowRightEndOnRectangle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowRightEndOnRectangle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowRightEndOnRectangle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowRightEndOnRectangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Right On Rectangle icon
    /// </summary>
    public static MarkupString ArrowRightOnRectangle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowRightOnRectangle(cssClass, widthAndHeight);

            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowRightOnRectangle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowRightOnRectangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Right Start On Rectangle icon
    /// </summary>
    public static MarkupString ArrowRightStartOnRectangle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowRightStartOnRectangle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowRightStartOnRectangle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowRightStartOnRectangle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowRightStartOnRectangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Right icon
    /// </summary>
    public static MarkupString ArrowRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Small Down icon
    /// </summary>
    public static MarkupString ArrowSmallDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowSmallDown(cssClass, widthAndHeight);

            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowSmallDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowSmallDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Small Left icon
    /// </summary>
    public static MarkupString ArrowSmallLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowSmallLeft(cssClass, widthAndHeight);

            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowSmallLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowSmallLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Small Right icon
    /// </summary>
    public static MarkupString ArrowSmallRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowSmallRight(cssClass, widthAndHeight);

            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowSmallRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowSmallRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Small Up icon
    /// </summary>
    public static MarkupString ArrowSmallUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowSmallUp(cssClass, widthAndHeight);

            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowSmallUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowSmallUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Top Right On Square icon
    /// </summary>
    public static MarkupString ArrowTopRightOnSquare(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowTopRightOnSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowTopRightOnSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowTopRightOnSquare(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowTopRightOnSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Trending Down icon
    /// </summary>
    public static MarkupString ArrowTrendingDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowTrendingDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowTrendingDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowTrendingDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowTrendingDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Trending Up icon
    /// </summary>
    public static MarkupString ArrowTrendingUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowTrendingUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowTrendingUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowTrendingUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowTrendingUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Up Circle icon
    /// </summary>
    public static MarkupString ArrowUpCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUpCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUpCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUpCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUpCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Up Left icon
    /// </summary>
    public static MarkupString ArrowUpLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUpLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUpLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUpLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUpLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Up On Square Stack icon
    /// </summary>
    public static MarkupString ArrowUpOnSquareStack(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUpOnSquareStack(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUpOnSquareStack(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUpOnSquareStack(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUpOnSquareStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Up On Square icon
    /// </summary>
    public static MarkupString ArrowUpOnSquare(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUpOnSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUpOnSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUpOnSquare(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUpOnSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Up Right icon
    /// </summary>
    public static MarkupString ArrowUpRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUpRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUpRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUpRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUpRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Up Tray icon
    /// </summary>
    public static MarkupString ArrowUpTray(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUpTray(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUpTray(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUpTray(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUpTray.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Up icon
    /// </summary>
    public static MarkupString ArrowUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Uturn Down icon
    /// </summary>
    public static MarkupString ArrowUturnDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUturnDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUturnDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUturnDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUturnDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Uturn Left icon
    /// </summary>
    public static MarkupString ArrowUturnLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUturnLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUturnLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUturnLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUturnLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Uturn Right icon
    /// </summary>
    public static MarkupString ArrowUturnRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUturnRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUturnRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUturnRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUturnRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrow Uturn Up icon
    /// </summary>
    public static MarkupString ArrowUturnUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowUturnUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowUturnUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowUturnUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowUturnUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrows Pointing In icon
    /// </summary>
    public static MarkupString ArrowsPointingIn(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowsPointingIn(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowsPointingIn(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowsPointingIn(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowsPointingIn.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrows Pointing Out icon
    /// </summary>
    public static MarkupString ArrowsPointingOut(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowsPointingOut(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowsPointingOut(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowsPointingOut(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowsPointingOut.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrows Right Left icon
    /// </summary>
    public static MarkupString ArrowsRightLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowsRightLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowsRightLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowsRightLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowsRightLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Arrows Up Down icon
    /// </summary>
    public static MarkupString ArrowsUpDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ArrowsUpDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ArrowsUpDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ArrowsUpDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ArrowsUpDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the At Symbol icon
    /// </summary>
    public static MarkupString AtSymbol(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.AtSymbol(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.AtSymbol(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.AtSymbol(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.AtSymbol.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Backspace icon
    /// </summary>
    public static MarkupString Backspace(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Backspace(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Backspace(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Backspace(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Backspace.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Backward icon
    /// </summary>
    public static MarkupString Backward(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Backward(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Backward(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Backward(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Backward.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Banknotes icon
    /// </summary>
    public static MarkupString Banknotes(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Banknotes(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Banknotes(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Banknotes(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Banknotes.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bars 2 icon
    /// </summary>
    public static MarkupString Bars2(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bars2(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bars2(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bars2(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bars2.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bars 3 Bottom Left icon
    /// </summary>
    public static MarkupString Bars3BottomLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bars3BottomLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bars3BottomLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bars3BottomLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bars3BottomLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bars 3 Bottom Right icon
    /// </summary>
    public static MarkupString Bars3BottomRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bars3BottomRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bars3BottomRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bars3BottomRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bars3BottomRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bars 3 Center Left icon
    /// </summary>
    public static MarkupString Bars3CenterLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bars3CenterLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bars3CenterLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bars3CenterLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bars3CenterLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bars 3 icon
    /// </summary>
    public static MarkupString Bars3(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bars3(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bars3(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bars3(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bars3.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bars 4 icon
    /// </summary>
    public static MarkupString Bars4(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bars4(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bars4(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bars4(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bars4.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bars Arrow Down icon
    /// </summary>
    public static MarkupString BarsArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BarsArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BarsArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BarsArrowDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BarsArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bars Arrow Up icon
    /// </summary>
    public static MarkupString BarsArrowUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BarsArrowUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BarsArrowUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BarsArrowUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BarsArrowUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Battery 0 icon
    /// </summary>
    public static MarkupString Battery0(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Battery0(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Battery0(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Battery0(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Battery0.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Battery 100 icon
    /// </summary>
    public static MarkupString Battery100(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Battery100(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Battery100(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Battery100(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Battery100.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Battery 50 icon
    /// </summary>
    public static MarkupString Battery50(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Battery50(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Battery50(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Battery50(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Battery50.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Beaker icon
    /// </summary>
    public static MarkupString Beaker(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Beaker(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Beaker(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Beaker(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Beaker.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bell Alert icon
    /// </summary>
    public static MarkupString BellAlert(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BellAlert(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BellAlert(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BellAlert(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BellAlert.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bell Slash icon
    /// </summary>
    public static MarkupString BellSlash(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BellSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BellSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BellSlash(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BellSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bell Snooze icon
    /// </summary>
    public static MarkupString BellSnooze(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BellSnooze(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BellSnooze(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BellSnooze(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BellSnooze.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bell icon
    /// </summary>
    public static MarkupString Bell(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bell(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bell(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bell(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bell.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bolt Slash icon
    /// </summary>
    public static MarkupString BoltSlash(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BoltSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BoltSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BoltSlash(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BoltSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bolt icon
    /// </summary>
    public static MarkupString Bolt(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bolt(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bolt(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bolt(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bolt.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Book Open icon
    /// </summary>
    public static MarkupString BookOpen(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BookOpen(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BookOpen(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BookOpen(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BookOpen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bookmark Slash icon
    /// </summary>
    public static MarkupString BookmarkSlash(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BookmarkSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BookmarkSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BookmarkSlash(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BookmarkSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bookmark Square icon
    /// </summary>
    public static MarkupString BookmarkSquare(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BookmarkSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BookmarkSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BookmarkSquare(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BookmarkSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bookmark icon
    /// </summary>
    public static MarkupString Bookmark(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Bookmark(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Bookmark(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Bookmark(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Bookmark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Briefcase icon
    /// </summary>
    public static MarkupString Briefcase(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Briefcase(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Briefcase(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Briefcase(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Briefcase.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Bug Ant icon
    /// </summary>
    public static MarkupString BugAnt(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BugAnt(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BugAnt(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BugAnt(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BugAnt.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Building Library icon
    /// </summary>
    public static MarkupString BuildingLibrary(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BuildingLibrary(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BuildingLibrary(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BuildingLibrary(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BuildingLibrary.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Building Office 2 icon
    /// </summary>
    public static MarkupString BuildingOffice2(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BuildingOffice2(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BuildingOffice2(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BuildingOffice2(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BuildingOffice2.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Building Office icon
    /// </summary>
    public static MarkupString BuildingOffice(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BuildingOffice(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BuildingOffice(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BuildingOffice(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BuildingOffice.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Building Storefront icon
    /// </summary>
    public static MarkupString BuildingStorefront(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.BuildingStorefront(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.BuildingStorefront(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.BuildingStorefront(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.BuildingStorefront.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cake icon
    /// </summary>
    public static MarkupString Cake(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Cake(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Cake(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Cake(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Cake.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Calculator icon
    /// </summary>
    public static MarkupString Calculator(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Calculator(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Calculator(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Calculator(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Calculator.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Calendar Days icon
    /// </summary>
    public static MarkupString CalendarDays(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CalendarDays(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CalendarDays(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CalendarDays(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CalendarDays.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Calendar icon
    /// </summary>
    public static MarkupString Calendar(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Calendar(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Calendar(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Calendar(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Calendar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Camera icon
    /// </summary>
    public static MarkupString Camera(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Camera(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Camera(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Camera(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Camera.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chart Bar Square icon
    /// </summary>
    public static MarkupString ChartBarSquare(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChartBarSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChartBarSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChartBarSquare(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChartBarSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chart Bar icon
    /// </summary>
    public static MarkupString ChartBar(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChartBar(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChartBar(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChartBar(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChartBar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chart Pie icon
    /// </summary>
    public static MarkupString ChartPie(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChartPie(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChartPie(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChartPie(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChartPie.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chat Bubble Bottom Center Text icon
    /// </summary>
    public static MarkupString ChatBubbleBottomCenterText(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChatBubbleBottomCenterText(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChatBubbleBottomCenterText(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChatBubbleBottomCenterText(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChatBubbleBottomCenterText.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chat Bubble Bottom Center icon
    /// </summary>
    public static MarkupString ChatBubbleBottomCenter(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChatBubbleBottomCenter(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChatBubbleBottomCenter(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChatBubbleBottomCenter(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChatBubbleBottomCenter.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chat Bubble Left Ellipsis icon
    /// </summary>
    public static MarkupString ChatBubbleLeftEllipsis(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChatBubbleLeftEllipsis(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChatBubbleLeftEllipsis(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChatBubbleLeftEllipsis(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChatBubbleLeftEllipsis.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chat Bubble Left Right icon
    /// </summary>
    public static MarkupString ChatBubbleLeftRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChatBubbleLeftRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChatBubbleLeftRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChatBubbleLeftRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChatBubbleLeftRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chat Bubble Left icon
    /// </summary>
    public static MarkupString ChatBubbleLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChatBubbleLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChatBubbleLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChatBubbleLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChatBubbleLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chat Bubble Oval Left Ellipsis icon
    /// </summary>
    public static MarkupString ChatBubbleOvalLeftEllipsis(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChatBubbleOvalLeftEllipsis(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChatBubbleOvalLeftEllipsis(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChatBubbleOvalLeftEllipsis(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChatBubbleOvalLeftEllipsis.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chat Bubble Oval Left icon
    /// </summary>
    public static MarkupString ChatBubbleOvalLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChatBubbleOvalLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChatBubbleOvalLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChatBubbleOvalLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChatBubbleOvalLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Check Badge icon
    /// </summary>
    public static MarkupString CheckBadge(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CheckBadge(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CheckBadge(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CheckBadge(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CheckBadge.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Check Circle icon
    /// </summary>
    public static MarkupString CheckCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CheckCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CheckCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CheckCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CheckCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Check icon
    /// </summary>
    public static MarkupString Check(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Check(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Check(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Check(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Check.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Double Down icon
    /// </summary>
    public static MarkupString ChevronDoubleDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronDoubleDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronDoubleDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronDoubleDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronDoubleDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Double Left icon
    /// </summary>
    public static MarkupString ChevronDoubleLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronDoubleLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronDoubleLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronDoubleLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronDoubleLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Double Right icon
    /// </summary>
    public static MarkupString ChevronDoubleRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronDoubleRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronDoubleRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronDoubleRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronDoubleRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Double Up icon
    /// </summary>
    public static MarkupString ChevronDoubleUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronDoubleUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronDoubleUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronDoubleUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronDoubleUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Down icon
    /// </summary>
    public static MarkupString ChevronDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Left icon
    /// </summary>
    public static MarkupString ChevronLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Right icon
    /// </summary>
    public static MarkupString ChevronRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Up Down icon
    /// </summary>
    public static MarkupString ChevronUpDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronUpDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronUpDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronUpDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronUpDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Chevron Up icon
    /// </summary>
    public static MarkupString ChevronUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ChevronUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ChevronUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ChevronUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ChevronUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Circle Stack icon
    /// </summary>
    public static MarkupString CircleStack(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CircleStack(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CircleStack(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CircleStack(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CircleStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Clipboard Document Check icon
    /// </summary>
    public static MarkupString ClipboardDocumentCheck(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ClipboardDocumentCheck(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ClipboardDocumentCheck(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ClipboardDocumentCheck(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ClipboardDocumentCheck.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Clipboard Document List icon
    /// </summary>
    public static MarkupString ClipboardDocumentList(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ClipboardDocumentList(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ClipboardDocumentList(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ClipboardDocumentList(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ClipboardDocumentList.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Clipboard Document icon
    /// </summary>
    public static MarkupString ClipboardDocument(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ClipboardDocument(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ClipboardDocument(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ClipboardDocument(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ClipboardDocument.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Clipboard icon
    /// </summary>
    public static MarkupString Clipboard(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Clipboard(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Clipboard(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Clipboard(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Clipboard.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Clock icon
    /// </summary>
    public static MarkupString Clock(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Clock(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Clock(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Clock(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Clock.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cloud Arrow Down icon
    /// </summary>
    public static MarkupString CloudArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CloudArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CloudArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CloudArrowDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CloudArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cloud Arrow Up icon
    /// </summary>
    public static MarkupString CloudArrowUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CloudArrowUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CloudArrowUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CloudArrowUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CloudArrowUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cloud icon
    /// </summary>
    public static MarkupString Cloud(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Cloud(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Cloud(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Cloud(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Cloud.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Code Bracket Square icon
    /// </summary>
    public static MarkupString CodeBracketSquare(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CodeBracketSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CodeBracketSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CodeBracketSquare(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CodeBracketSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Code Bracket icon
    /// </summary>
    public static MarkupString CodeBracket(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CodeBracket(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CodeBracket(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CodeBracket(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CodeBracket.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cog 6 Tooth icon
    /// </summary>
    public static MarkupString Cog6Tooth(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Cog6Tooth(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Cog6Tooth(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Cog6Tooth(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Cog6Tooth.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cog 8 Tooth icon
    /// </summary>
    public static MarkupString Cog8Tooth(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Cog8Tooth(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Cog8Tooth(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Cog8Tooth(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Cog8Tooth.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cog icon
    /// </summary>
    public static MarkupString Cog(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Cog(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Cog(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Cog(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Cog.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Command Line icon
    /// </summary>
    public static MarkupString CommandLine(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CommandLine(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CommandLine(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CommandLine(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CommandLine.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Computer Desktop icon
    /// </summary>
    public static MarkupString ComputerDesktop(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ComputerDesktop(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ComputerDesktop(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ComputerDesktop(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ComputerDesktop.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cpu Chip icon
    /// </summary>
    public static MarkupString CpuChip(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CpuChip(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CpuChip(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CpuChip(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CpuChip.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Credit Card icon
    /// </summary>
    public static MarkupString CreditCard(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CreditCard(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CreditCard(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CreditCard(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CreditCard.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cube Transparent icon
    /// </summary>
    public static MarkupString CubeTransparent(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CubeTransparent(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CubeTransparent(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CubeTransparent(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CubeTransparent.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cube icon
    /// </summary>
    public static MarkupString Cube(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Cube(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Cube(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Cube(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Cube.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Currency Bangladeshi icon
    /// </summary>
    public static MarkupString CurrencyBangladeshi(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CurrencyBangladeshi(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CurrencyBangladeshi(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CurrencyBangladeshi(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CurrencyBangladeshi.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Currency Dollar icon
    /// </summary>
    public static MarkupString CurrencyDollar(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CurrencyDollar(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CurrencyDollar(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CurrencyDollar(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CurrencyDollar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Currency Euro icon
    /// </summary>
    public static MarkupString CurrencyEuro(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CurrencyEuro(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CurrencyEuro(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CurrencyEuro(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CurrencyEuro.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Currency Pound icon
    /// </summary>
    public static MarkupString CurrencyPound(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CurrencyPound(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CurrencyPound(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CurrencyPound(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CurrencyPound.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Currency Rupee icon
    /// </summary>
    public static MarkupString CurrencyRupee(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CurrencyRupee(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CurrencyRupee(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CurrencyRupee(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CurrencyRupee.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Currency Yen icon
    /// </summary>
    public static MarkupString CurrencyYen(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CurrencyYen(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CurrencyYen(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CurrencyYen(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CurrencyYen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cursor Arrow Rays icon
    /// </summary>
    public static MarkupString CursorArrowRays(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CursorArrowRays(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CursorArrowRays(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CursorArrowRays(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CursorArrowRays.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Cursor Arrow Ripple icon
    /// </summary>
    public static MarkupString CursorArrowRipple(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.CursorArrowRipple(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.CursorArrowRipple(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.CursorArrowRipple(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.CursorArrowRipple.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Device Phone Mobile icon
    /// </summary>
    public static MarkupString DevicePhoneMobile(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DevicePhoneMobile(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DevicePhoneMobile(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DevicePhoneMobile(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DevicePhoneMobile.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Device Tablet icon
    /// </summary>
    public static MarkupString DeviceTablet(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DeviceTablet(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DeviceTablet(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DeviceTablet(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DeviceTablet.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Arrow Down icon
    /// </summary>
    public static MarkupString DocumentArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentArrowDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Arrow Up icon
    /// </summary>
    public static MarkupString DocumentArrowUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentArrowUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentArrowUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentArrowUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentArrowUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Chart Bar icon
    /// </summary>
    public static MarkupString DocumentChartBar(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentChartBar(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentChartBar(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentChartBar(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentChartBar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Check icon
    /// </summary>
    public static MarkupString DocumentCheck(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentCheck(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentCheck(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentCheck(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentCheck.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Duplicate icon
    /// </summary>
    public static MarkupString DocumentDuplicate(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentDuplicate(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentDuplicate(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentDuplicate(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentDuplicate.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Magnifying Glass icon
    /// </summary>
    public static MarkupString DocumentMagnifyingGlass(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentMagnifyingGlass(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentMagnifyingGlass(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentMagnifyingGlass(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentMagnifyingGlass.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Minus icon
    /// </summary>
    public static MarkupString DocumentMinus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentMinus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentMinus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentMinus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentMinus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Plus icon
    /// </summary>
    public static MarkupString DocumentPlus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentPlus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document Text icon
    /// </summary>
    public static MarkupString DocumentText(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.DocumentText(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.DocumentText(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.DocumentText(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.DocumentText.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Document icon
    /// </summary>
    public static MarkupString Document(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Document(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Document(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Document(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Document.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Ellipsis Horizontal Circle icon
    /// </summary>
    public static MarkupString EllipsisHorizontalCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.EllipsisHorizontalCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.EllipsisHorizontalCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.EllipsisHorizontalCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.EllipsisHorizontalCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Ellipsis Horizontal icon
    /// </summary>
    public static MarkupString EllipsisHorizontal(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.EllipsisHorizontal(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.EllipsisHorizontal(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.EllipsisHorizontal(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.EllipsisHorizontal.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Ellipsis Vertical icon
    /// </summary>
    public static MarkupString EllipsisVertical(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.EllipsisVertical(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.EllipsisVertical(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.EllipsisVertical(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.EllipsisVertical.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Envelope Open icon
    /// </summary>
    public static MarkupString EnvelopeOpen(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.EnvelopeOpen(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.EnvelopeOpen(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.EnvelopeOpen(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.EnvelopeOpen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Envelope icon
    /// </summary>
    public static MarkupString Envelope(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Envelope(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Envelope(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Envelope(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Envelope.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Exclamation Circle icon
    /// </summary>
    public static MarkupString ExclamationCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ExclamationCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ExclamationCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ExclamationCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ExclamationCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Exclamation Triangle icon
    /// </summary>
    public static MarkupString ExclamationTriangle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ExclamationTriangle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ExclamationTriangle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ExclamationTriangle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ExclamationTriangle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Eye Dropper icon
    /// </summary>
    public static MarkupString EyeDropper(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.EyeDropper(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.EyeDropper(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.EyeDropper(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.EyeDropper.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Eye Slash icon
    /// </summary>
    public static MarkupString EyeSlash(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.EyeSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.EyeSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.EyeSlash(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.EyeSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Eye icon
    /// </summary>
    public static MarkupString Eye(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Eye(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Eye(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Eye(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Eye.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Face Frown icon
    /// </summary>
    public static MarkupString FaceFrown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.FaceFrown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.FaceFrown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.FaceFrown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.FaceFrown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Face Smile icon
    /// </summary>
    public static MarkupString FaceSmile(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.FaceSmile(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.FaceSmile(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.FaceSmile(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.FaceSmile.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Film icon
    /// </summary>
    public static MarkupString Film(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Film(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Film(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Film(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Film.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Finger Print icon
    /// </summary>
    public static MarkupString FingerPrint(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.FingerPrint(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.FingerPrint(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.FingerPrint(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.FingerPrint.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Fire icon
    /// </summary>
    public static MarkupString Fire(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Fire(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Fire(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Fire(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Fire.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Flag icon
    /// </summary>
    public static MarkupString Flag(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Flag(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Flag(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Flag(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Flag.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Folder Arrow Down icon
    /// </summary>
    public static MarkupString FolderArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.FolderArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.FolderArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.FolderArrowDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.FolderArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Folder Minus icon
    /// </summary>
    public static MarkupString FolderMinus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.FolderMinus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.FolderMinus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.FolderMinus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.FolderMinus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Folder Open icon
    /// </summary>
    public static MarkupString FolderOpen(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.FolderOpen(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.FolderOpen(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.FolderOpen(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.FolderOpen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Folder Plus icon
    /// </summary>
    public static MarkupString FolderPlus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.FolderPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.FolderPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.FolderPlus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.FolderPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Folder icon
    /// </summary>
    public static MarkupString Folder(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Folder(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Folder(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Folder(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Folder.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Forward icon
    /// </summary>
    public static MarkupString Forward(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Forward(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Forward(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Forward(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Forward.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Funnel icon
    /// </summary>
    public static MarkupString Funnel(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Funnel(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Funnel(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Funnel(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Funnel.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Gif icon
    /// </summary>
    public static MarkupString Gif(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Gif(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Gif(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Gif(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Gif.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Gift Top icon
    /// </summary>
    public static MarkupString GiftTop(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.GiftTop(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.GiftTop(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.GiftTop(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.GiftTop.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Gift icon
    /// </summary>
    public static MarkupString Gift(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Gift(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Gift(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Gift(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Gift.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Globe Alt icon
    /// </summary>
    public static MarkupString GlobeAlt(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.GlobeAlt(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.GlobeAlt(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.GlobeAlt(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.GlobeAlt.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Globe Americas icon
    /// </summary>
    public static MarkupString GlobeAmericas(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.GlobeAmericas(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.GlobeAmericas(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.GlobeAmericas(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.GlobeAmericas.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Globe Asia Australia icon
    /// </summary>
    public static MarkupString GlobeAsiaAustralia(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.GlobeAsiaAustralia(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.GlobeAsiaAustralia(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.GlobeAsiaAustralia(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.GlobeAsiaAustralia.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Globe Europe Africa icon
    /// </summary>
    public static MarkupString GlobeEuropeAfrica(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.GlobeEuropeAfrica(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.GlobeEuropeAfrica(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.GlobeEuropeAfrica(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.GlobeEuropeAfrica.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Hand Raised icon
    /// </summary>
    public static MarkupString HandRaised(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.HandRaised(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.HandRaised(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.HandRaised(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.HandRaised.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Hand Thumb Down icon
    /// </summary>
    public static MarkupString HandThumbDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.HandThumbDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.HandThumbDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.HandThumbDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.HandThumbDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Hand Thumb Up icon
    /// </summary>
    public static MarkupString HandThumbUp(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.HandThumbUp(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.HandThumbUp(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.HandThumbUp(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.HandThumbUp.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Hashtag icon
    /// </summary>
    public static MarkupString Hashtag(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Hashtag(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Hashtag(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Hashtag(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Hashtag.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Heart icon
    /// </summary>
    public static MarkupString Heart(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Heart(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Heart(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Heart(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Heart.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Home Modern icon
    /// </summary>
    public static MarkupString HomeModern(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.HomeModern(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.HomeModern(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.HomeModern(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.HomeModern.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Home icon
    /// </summary>
    public static MarkupString Home(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Home(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Home(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Home(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Home.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Identification icon
    /// </summary>
    public static MarkupString Identification(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Identification(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Identification(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Identification(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Identification.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Inbox Arrow Down icon
    /// </summary>
    public static MarkupString InboxArrowDown(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.InboxArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.InboxArrowDown(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.InboxArrowDown(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.InboxArrowDown.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Inbox Stack icon
    /// </summary>
    public static MarkupString InboxStack(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.InboxStack(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.InboxStack(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.InboxStack(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.InboxStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Inbox icon
    /// </summary>
    public static MarkupString Inbox(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Inbox(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Inbox(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Inbox(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Inbox.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Information Circle icon
    /// </summary>
    public static MarkupString InformationCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.InformationCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.InformationCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.InformationCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.InformationCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Key icon
    /// </summary>
    public static MarkupString Key(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Key(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Key(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Key(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Key.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Language icon
    /// </summary>
    public static MarkupString Language(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Language(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Language(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Language(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Language.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Lifebuoy icon
    /// </summary>
    public static MarkupString Lifebuoy(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Lifebuoy(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Lifebuoy(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Lifebuoy(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Lifebuoy.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Light Bulb icon
    /// </summary>
    public static MarkupString LightBulb(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.LightBulb(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.LightBulb(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.LightBulb(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.LightBulb.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Link icon
    /// </summary>
    public static MarkupString Link(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Link(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Link(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Link(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Link.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the List Bullet icon
    /// </summary>
    public static MarkupString ListBullet(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ListBullet(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ListBullet(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ListBullet(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ListBullet.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Lock Closed icon
    /// </summary>
    public static MarkupString LockClosed(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.LockClosed(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.LockClosed(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.LockClosed(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.LockClosed.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Lock Open icon
    /// </summary>
    public static MarkupString LockOpen(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.LockOpen(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.LockOpen(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.LockOpen(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.LockOpen.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Magnifying Glass Circle icon
    /// </summary>
    public static MarkupString MagnifyingGlassCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.MagnifyingGlassCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.MagnifyingGlassCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.MagnifyingGlassCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.MagnifyingGlassCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Magnifying Glass Minus icon
    /// </summary>
    public static MarkupString MagnifyingGlassMinus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.MagnifyingGlassMinus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.MagnifyingGlassMinus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.MagnifyingGlassMinus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.MagnifyingGlassMinus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Magnifying Glass Plus icon
    /// </summary>
    public static MarkupString MagnifyingGlassPlus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.MagnifyingGlassPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.MagnifyingGlassPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.MagnifyingGlassPlus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.MagnifyingGlassPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Magnifying Glass icon
    /// </summary>
    public static MarkupString MagnifyingGlass(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.MagnifyingGlass(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.MagnifyingGlass(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.MagnifyingGlass(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.MagnifyingGlass.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Map Pin icon
    /// </summary>
    public static MarkupString MapPin(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.MapPin(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.MapPin(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.MapPin(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.MapPin.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Map icon
    /// </summary>
    public static MarkupString Map(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Map(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Map(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Map(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Map.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Megaphone icon
    /// </summary>
    public static MarkupString Megaphone(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Megaphone(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Megaphone(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Megaphone(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Megaphone.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Microphone icon
    /// </summary>
    public static MarkupString Microphone(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Microphone(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Microphone(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Microphone(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Microphone.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Minus Circle icon
    /// </summary>
    public static MarkupString MinusCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.MinusCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.MinusCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.MinusCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.MinusCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Minus Small icon
    /// </summary>
    public static MarkupString MinusSmall(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.MinusSmall(cssClass, widthAndHeight);

            case HeroIconTypes.Mini:
                return HeroIconsMini.MinusSmall(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.MinusSmall.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Minus icon
    /// </summary>
    public static MarkupString Minus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Minus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Minus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Minus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Minus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Moon icon
    /// </summary>
    public static MarkupString Moon(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Moon(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Moon(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Moon(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Moon.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Musical Note icon
    /// </summary>
    public static MarkupString MusicalNote(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.MusicalNote(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.MusicalNote(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.MusicalNote(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.MusicalNote.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Newspaper icon
    /// </summary>
    public static MarkupString Newspaper(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Newspaper(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Newspaper(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Newspaper(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Newspaper.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the No Symbol icon
    /// </summary>
    public static MarkupString NoSymbol(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.NoSymbol(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.NoSymbol(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.NoSymbol(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.NoSymbol.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Paint Brush icon
    /// </summary>
    public static MarkupString PaintBrush(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PaintBrush(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PaintBrush(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PaintBrush(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PaintBrush.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Paper Airplane icon
    /// </summary>
    public static MarkupString PaperAirplane(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PaperAirplane(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PaperAirplane(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PaperAirplane(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PaperAirplane.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Paper Clip icon
    /// </summary>
    public static MarkupString PaperClip(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PaperClip(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PaperClip(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PaperClip(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PaperClip.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Pause Circle icon
    /// </summary>
    public static MarkupString PauseCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PauseCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PauseCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PauseCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PauseCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Pause icon
    /// </summary>
    public static MarkupString Pause(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Pause(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Pause(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Pause(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Pause.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Pencil Square icon
    /// </summary>
    public static MarkupString PencilSquare(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PencilSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PencilSquare(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PencilSquare(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PencilSquare.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Pencil icon
    /// </summary>
    public static MarkupString Pencil(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Pencil(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Pencil(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Pencil(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Pencil.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Phone Arrow Down Left icon
    /// </summary>
    public static MarkupString PhoneArrowDownLeft(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PhoneArrowDownLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PhoneArrowDownLeft(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PhoneArrowDownLeft(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PhoneArrowDownLeft.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Phone Arrow Up Right icon
    /// </summary>
    public static MarkupString PhoneArrowUpRight(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PhoneArrowUpRight(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PhoneArrowUpRight(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PhoneArrowUpRight(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PhoneArrowUpRight.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Phone X Mark icon
    /// </summary>
    public static MarkupString PhoneXMark(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PhoneXMark(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PhoneXMark(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PhoneXMark(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PhoneXMark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Phone icon
    /// </summary>
    public static MarkupString Phone(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Phone(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Phone(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Phone(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Phone.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Photo icon
    /// </summary>
    public static MarkupString Photo(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Photo(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Photo(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Photo(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Photo.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Play Circle icon
    /// </summary>
    public static MarkupString PlayCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PlayCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PlayCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PlayCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PlayCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Play Pause icon
    /// </summary>
    public static MarkupString PlayPause(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PlayPause(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PlayPause(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PlayPause(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PlayPause.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Play icon
    /// </summary>
    public static MarkupString Play(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Play(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Play(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Play(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Play.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Plus Circle icon
    /// </summary>
    public static MarkupString PlusCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PlusCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PlusCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PlusCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PlusCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Plus Small icon
    /// </summary>
    public static MarkupString PlusSmall(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PlusSmall(cssClass, widthAndHeight);

            case HeroIconTypes.Mini:
                return HeroIconsMini.PlusSmall(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PlusSmall.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Plus icon
    /// </summary>
    public static MarkupString Plus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Plus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Plus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Plus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Plus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Power icon
    /// </summary>
    public static MarkupString Power(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Power(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Power(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Power(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Power.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Presentation Chart Bar icon
    /// </summary>
    public static MarkupString PresentationChartBar(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PresentationChartBar(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PresentationChartBar(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PresentationChartBar(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PresentationChartBar.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Presentation Chart Line icon
    /// </summary>
    public static MarkupString PresentationChartLine(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PresentationChartLine(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PresentationChartLine(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PresentationChartLine(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PresentationChartLine.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Printer icon
    /// </summary>
    public static MarkupString Printer(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Printer(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Printer(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Printer(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Printer.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Puzzle Piece icon
    /// </summary>
    public static MarkupString PuzzlePiece(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.PuzzlePiece(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.PuzzlePiece(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.PuzzlePiece(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.PuzzlePiece.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Qr Code icon
    /// </summary>
    public static MarkupString QrCode(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.QrCode(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.QrCode(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.QrCode(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.QrCode.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Question Mark Circle icon
    /// </summary>
    public static MarkupString QuestionMarkCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.QuestionMarkCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.QuestionMarkCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.QuestionMarkCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.QuestionMarkCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Queue List icon
    /// </summary>
    public static MarkupString QueueList(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.QueueList(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.QueueList(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.QueueList(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.QueueList.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Radio icon
    /// </summary>
    public static MarkupString Radio(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Radio(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Radio(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Radio(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Radio.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Receipt Percent icon
    /// </summary>
    public static MarkupString ReceiptPercent(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ReceiptPercent(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ReceiptPercent(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ReceiptPercent(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ReceiptPercent.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Receipt Refund icon
    /// </summary>
    public static MarkupString ReceiptRefund(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ReceiptRefund(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ReceiptRefund(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ReceiptRefund(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ReceiptRefund.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Rectangle Group icon
    /// </summary>
    public static MarkupString RectangleGroup(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.RectangleGroup(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.RectangleGroup(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.RectangleGroup(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.RectangleGroup.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Rectangle Stack icon
    /// </summary>
    public static MarkupString RectangleStack(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.RectangleStack(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.RectangleStack(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.RectangleStack(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.RectangleStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Rocket Launch icon
    /// </summary>
    public static MarkupString RocketLaunch(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.RocketLaunch(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.RocketLaunch(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.RocketLaunch(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.RocketLaunch.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Rss icon
    /// </summary>
    public static MarkupString Rss(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Rss(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Rss(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Rss(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Rss.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Scale icon
    /// </summary>
    public static MarkupString Scale(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Scale(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Scale(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Scale(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Scale.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Scissors icon
    /// </summary>
    public static MarkupString Scissors(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Scissors(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Scissors(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Scissors(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Scissors.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Server Stack icon
    /// </summary>
    public static MarkupString ServerStack(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ServerStack(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ServerStack(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ServerStack(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ServerStack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Server icon
    /// </summary>
    public static MarkupString Server(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Server(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Server(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Server(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Server.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Share icon
    /// </summary>
    public static MarkupString Share(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Share(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Share(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Share(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Share.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Shield Check icon
    /// </summary>
    public static MarkupString ShieldCheck(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ShieldCheck(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ShieldCheck(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ShieldCheck(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ShieldCheck.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Shield Exclamation icon
    /// </summary>
    public static MarkupString ShieldExclamation(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ShieldExclamation(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ShieldExclamation(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ShieldExclamation(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ShieldExclamation.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Shopping Bag icon
    /// </summary>
    public static MarkupString ShoppingBag(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ShoppingBag(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ShoppingBag(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ShoppingBag(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ShoppingBag.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Shopping Cart icon
    /// </summary>
    public static MarkupString ShoppingCart(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ShoppingCart(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ShoppingCart(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ShoppingCart(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ShoppingCart.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Signal Slash icon
    /// </summary>
    public static MarkupString SignalSlash(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.SignalSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.SignalSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.SignalSlash(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.SignalSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Signal icon
    /// </summary>
    public static MarkupString Signal(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Signal(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Signal(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Signal(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Signal.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Sparkles icon
    /// </summary>
    public static MarkupString Sparkles(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Sparkles(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Sparkles(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Sparkles(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Sparkles.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Speaker Wave icon
    /// </summary>
    public static MarkupString SpeakerWave(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.SpeakerWave(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.SpeakerWave(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.SpeakerWave(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.SpeakerWave.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Speaker X Mark icon
    /// </summary>
    public static MarkupString SpeakerXMark(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.SpeakerXMark(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.SpeakerXMark(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.SpeakerXMark(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.SpeakerXMark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Square 2 Stack icon
    /// </summary>
    public static MarkupString Square2Stack(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Square2Stack(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Square2Stack(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Square2Stack(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Square2Stack.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Square 3 Stack 3D icon
    /// </summary>
    public static MarkupString Square3Stack3D(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Square3Stack3D(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Square3Stack3D(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Square3Stack3D(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Square3Stack3D.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Squares 2X2 icon
    /// </summary>
    public static MarkupString Squares2X2(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Squares2X2(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Squares2X2(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Squares2X2(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Squares2X2.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Squares Plus icon
    /// </summary>
    public static MarkupString SquaresPlus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.SquaresPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.SquaresPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.SquaresPlus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.SquaresPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Star icon
    /// </summary>
    public static MarkupString Star(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Star(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Star(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Star(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Star.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Stop Circle icon
    /// </summary>
    public static MarkupString StopCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.StopCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.StopCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.StopCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.StopCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Stop icon
    /// </summary>
    public static MarkupString Stop(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Stop(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Stop(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Stop(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Stop.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Sun icon
    /// </summary>
    public static MarkupString Sun(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Sun(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Sun(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Sun(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Sun.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Swatch icon
    /// </summary>
    public static MarkupString Swatch(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Swatch(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Swatch(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Swatch(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Swatch.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Table Cells icon
    /// </summary>
    public static MarkupString TableCells(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.TableCells(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.TableCells(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.TableCells(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.TableCells.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Tag icon
    /// </summary>
    public static MarkupString Tag(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Tag(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Tag(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Tag(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Tag.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Ticket icon
    /// </summary>
    public static MarkupString Ticket(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Ticket(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Ticket(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Ticket(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Ticket.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Trash icon
    /// </summary>
    public static MarkupString Trash(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Trash(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Trash(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Trash(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Trash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Trophy icon
    /// </summary>
    public static MarkupString Trophy(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Trophy(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Trophy(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Trophy(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Trophy.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Truck icon
    /// </summary>
    public static MarkupString Truck(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Truck(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Truck(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Truck(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Truck.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Tv icon
    /// </summary>
    public static MarkupString Tv(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Tv(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Tv(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Tv(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Tv.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the User Circle icon
    /// </summary>
    public static MarkupString UserCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.UserCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.UserCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.UserCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.UserCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the User Group icon
    /// </summary>
    public static MarkupString UserGroup(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.UserGroup(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.UserGroup(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.UserGroup(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.UserGroup.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the User Minus icon
    /// </summary>
    public static MarkupString UserMinus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.UserMinus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.UserMinus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.UserMinus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.UserMinus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the User Plus icon
    /// </summary>
    public static MarkupString UserPlus(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.UserPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.UserPlus(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.UserPlus(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.UserPlus.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the User icon
    /// </summary>
    public static MarkupString User(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.User(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.User(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.User(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.User.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Users icon
    /// </summary>
    public static MarkupString Users(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Users(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Users(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Users(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Users.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Variable icon
    /// </summary>
    public static MarkupString Variable(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Variable(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Variable(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Variable(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Variable.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Video Camera Slash icon
    /// </summary>
    public static MarkupString VideoCameraSlash(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.VideoCameraSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.VideoCameraSlash(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.VideoCameraSlash(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.VideoCameraSlash.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Video Camera icon
    /// </summary>
    public static MarkupString VideoCamera(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.VideoCamera(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.VideoCamera(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.VideoCamera(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.VideoCamera.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the View Columns icon
    /// </summary>
    public static MarkupString ViewColumns(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ViewColumns(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ViewColumns(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ViewColumns(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ViewColumns.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Viewfinder Circle icon
    /// </summary>
    public static MarkupString ViewfinderCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.ViewfinderCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.ViewfinderCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.ViewfinderCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.ViewfinderCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Wallet icon
    /// </summary>
    public static MarkupString Wallet(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Wallet(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Wallet(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Wallet(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Wallet.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Wifi icon
    /// </summary>
    public static MarkupString Wifi(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Wifi(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Wifi(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Wifi(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Wifi.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Window icon
    /// </summary>
    public static MarkupString Window(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Window(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Window(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Window(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Window.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Wrench Screwdriver icon
    /// </summary>
    public static MarkupString WrenchScrewdriver(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.WrenchScrewdriver(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.WrenchScrewdriver(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.WrenchScrewdriver(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.WrenchScrewdriver.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the Wrench icon
    /// </summary>
    public static MarkupString Wrench(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.Wrench(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.Wrench(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.Wrench(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.Wrench.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the X Circle icon
    /// </summary>
    public static MarkupString XCircle(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.XCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.XCircle(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.XCircle(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.XCircle.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }

    /// <summary>
    /// Returns the X Mark icon
    /// </summary>
    public static MarkupString XMark(string cssClass = "", string widthAndHeight = "w-5 h-5", HeroIconTypes iconType = HeroIconTypes.Solid)
    {
        switch (iconType)
        {
            case HeroIconTypes.Outline:
                return HeroIconsOutline.XMark(cssClass, widthAndHeight);
            case HeroIconTypes.Micro:
                return HeroIconsMicro.XMark(cssClass, widthAndHeight);
            case HeroIconTypes.Mini:
                return HeroIconsMini.XMark(cssClass, widthAndHeight);
        }

        return new MarkupString(HeroIconsSolidResources.XMark.Replace("{CssClass}", $"{cssClass} {widthAndHeight}"));
    }


}

