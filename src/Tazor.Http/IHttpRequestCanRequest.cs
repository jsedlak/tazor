namespace Tazor.Http;

public interface IHttpRequestCanRequest
{
    IHttpRequestCanRequest WithHeaders(IDictionary<string, string> headers);

    IHttpRequestCanRequest WithHeader(string key, string value);

    Task<TModel?> RequestAsJsonAsync<TModel>();

    Task<TModel?> RequestAsJsonAsync<TInput, TModel>(TInput body);

    Task<HttpResponseMessage> RequestAsync();

    Task<HttpResponseMessage> RequestAsync<TInput>(TInput body);
}