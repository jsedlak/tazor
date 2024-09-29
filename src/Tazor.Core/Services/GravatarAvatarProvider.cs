using System.Text;
using Tazor.ServiceModel;

namespace Tazor.Services;

public class GravatarAvatarProvider : IAvatarProvider
{
    public Task<string?> GetAvatarImageUrl(string identifier)
    {
        var hasher = System.Security.Cryptography.SHA256.Create();
        var hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(identifier));
        return Task.FromResult<string?>($"https://gravatar.com/avatar/{hash}");
    }
}
