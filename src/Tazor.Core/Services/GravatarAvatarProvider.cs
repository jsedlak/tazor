using System.Text;
using Tazor.ServiceModel;

namespace Tazor.Services;

/// <summary>
/// A simple avatar provider that generates a gravatar image URL from a provided e-mail address.
/// </summary>
public class GravatarAvatarProvider : IAvatarProvider
{
    /// <inheritdoc />
    public Task<string?> GetAvatarImageUrl(string identifier)
    {
        var hasher = System.Security.Cryptography.SHA256.Create();
        var hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(identifier));
        return Task.FromResult<string?>($"https://gravatar.com/avatar/{hash}");
    }
}
