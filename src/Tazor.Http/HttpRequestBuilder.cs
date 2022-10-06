using Tazor.Serialization;

namespace Tazor.Http;

public sealed class HttpRequestBuilder : IHttpRequestCanSetRouting, IHttpRequestCanRequest
{
    private string _url = "";
    private HttpMethod _method = HttpMethod.Get;
    private Dictionary<string, string> _headers = new Dictionary<string, string>();

    private HttpClient _client = null!;
    private readonly ISerializer _serializer;

    public HttpRequestBuilder(HttpClient client, ISerializer serializer)
    {
        _client = client;
        _serializer = serializer;
    }

    #region IHttpRequestCanSetRouting
    public IHttpRequestCanRequest WithUrl(HttpMethod method, string url)
    {
        _method = method;
        _url = url;

        return this;
    }

    public IHttpRequestCanRequest WithGet(string url) => WithUrl(HttpMethod.Get, url);

    public IHttpRequestCanRequest WithPost(string url) => WithUrl(HttpMethod.Post, url);

    public IHttpRequestCanRequest WithPut(string url) => WithUrl(HttpMethod.Put, url);

    public IHttpRequestCanRequest WithPatch(string url) => WithUrl(HttpMethod.Patch, url);

    public IHttpRequestCanRequest WithDelete(string url) => WithUrl(HttpMethod.Delete, url);
    #endregion

    #region IHttpRequestCanRequest
    public IHttpRequestCanRequest WithHeaders(IDictionary<string, string> headers)
    {
        foreach(var header in headers)
        {
           _headers.Add(header.Key, header.Value);
        }

        return this;
    }

    public IHttpRequestCanRequest WithHeader(string key, string value)
    {
        _headers.Add(key, value);

        return this;
    }

    public async Task<TModel?> RequestAsJsonAsync<TModel>()
    {
        using var requestMessage = new HttpRequestMessage(_method, _url);

        foreach(var header in _headers)
        {
            requestMessage.Headers.Add(header.Key, header.Value);
        }

        var response = await _client.SendAsync(requestMessage);
        var content = await response.Content.ReadAsStringAsync();

        return _serializer.Deserialize<TModel>(content);
    }

    public async Task<TModel?> RequestAsJsonAsync<TInput, TModel>(TInput body)
    {
        if(body == null)
        {
            throw new ArgumentNullException("body");
        }

        using var requestMessage = new HttpRequestMessage(_method, _url);

        foreach (var header in _headers)
        {
            requestMessage.Headers.Add(header.Key, header.Value);
        }

        var jsonData = _serializer.Serialize(body);
        var bodyContent = new StringContent(jsonData);
        requestMessage.Content = bodyContent;

        var response = await _client.SendAsync(requestMessage);
        var content = await response.Content.ReadAsStringAsync();

        return _serializer.Deserialize<TModel>(content);
    }

    public async Task<HttpResponseMessage> RequestAsync()
    {
        using var requestMessage = new HttpRequestMessage(_method, _url);

        foreach (var header in _headers)
        {
            requestMessage.Headers.Add(header.Key, header.Value);
        }

        return await _client.SendAsync(requestMessage);
    }

    public async Task<HttpResponseMessage> RequestAsync<TInput>(TInput body)
    {
        if (body == null)
        {
            throw new ArgumentNullException("body");
        }

        using var requestMessage = new HttpRequestMessage(_method, _url);

        foreach (var header in _headers)
        {
            requestMessage.Headers.Add(header.Key, header.Value);
        }

        var jsonData = _serializer.Serialize(body);
        var bodyContent = new StringContent(jsonData);
        requestMessage.Content = bodyContent;

        return await _client.SendAsync(requestMessage);
    }
    #endregion
}
