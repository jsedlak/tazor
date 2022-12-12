namespace Tazor.Http
{
    public interface IHttpMessengerFactory
    {
        IHttpMessenger Create(string namedHttpClient);
    }
}