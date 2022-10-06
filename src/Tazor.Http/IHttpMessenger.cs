namespace Tazor.Http;

public interface IHttpMessenger : IHttpRequestCanSetRouting
{
    Task<TModel?> GetSerializedAsync<TModel>(string requestUri, IDictionary<string, string>? headers = null);

    Task<HttpResponseMessage> PostSerializedAsync<TModel>(string requestUri, TModel model, IDictionary<string, string>? headers = null);

    Task<HttpResponseMessage> PutSerializedAsync<TModel>(string requestUri, TModel model, IDictionary<string, string>? headers = null);

    Task<HttpResponseMessage> DeleteSerializedAsync(string requestUri, IDictionary<string, string>? headers = null);
}
