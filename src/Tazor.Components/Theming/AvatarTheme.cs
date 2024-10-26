namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the avatar component
/// </summary>
public sealed class AvatarTheme
{
    /// <summary>
    /// Gets or Sets the wrapper theming
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the theming for the image
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets theming for the initials
    /// </summary>
    public string Initials { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets size theming for extra small avatars
    /// </summary>
    public string ExtraSmall { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets size theming for small avatars
    /// </summary>
    public string Small { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets size theming for medium avatars
    /// </summary>
    public string Medium { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets size theming for large avatars
    /// </summary>
    public string Large { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets size theming for extra large avatars
    /// </summary>
    public string ExtraLarge { get; set; } = string.Empty;
}
