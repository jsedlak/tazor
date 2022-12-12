using Tazor.Serialization;

namespace Tazor.Http;

public sealed class SerializedHttpMessengerFactory : IHttpMessengerFactory
{
    private readonly ISerializer _serializer;
    private readonly IHttpClientFactory _httpClientFactory;

    public SerializedHttpMessengerFactory(ISerializer serializer, IHttpClientFactory httpClientFactory)
    {
        _serializer = serializer;
        _httpClientFactory = httpClientFactory;
    }

    public IHttpMessenger Create(string namedHttpClient)
    {
        return new SerializedHttpMessenger(
            _httpClientFactory.CreateClient(namedHttpClient),
            _serializer
        );
    }
}
