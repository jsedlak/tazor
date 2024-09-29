namespace Tazor.ServiceModel;

/// <summary>
/// Provides a way to get an avatar image URL for a given user identifier.
/// </summary>
public interface IAvatarProvider
{
    /// <summary>
    /// Gets the avatar image URL for the given user identifier.
    /// </summary>
    /// <param name="identifier">The identifier of the user</param>
    /// <returns>A URL to the avatar for the user, or null if the user cannot be found</returns>
    Task<string?> GetAvatarImageUrl(string identifier);
}
