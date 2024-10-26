namespace Tazor.Components.Utility;

/// <summary>
/// Contains the data associated with a breakpoint
/// </summary>
public class BreakpointParams
{
    /// <summary>
    /// Gets or Sets the width of the browser
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Gets or Sets the height of the browser
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Gets or Sets the current breakpoint represented by the width and height
    /// </summary>
    public string Breakpoint { get; set; } = null!;
}