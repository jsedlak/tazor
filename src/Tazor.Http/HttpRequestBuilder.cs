using Tazor.Serialization;

namespace Tazor.Http;

/// <summary>
/// Represents a fluent interface into building HTTP requests with the HttpClient provider
/// </summary>
public sealed class HttpRequestBuilder : IHttpRequestCanSetRouting, IHttpRequestCanRequest
{
    private string _url = "";
    private HttpMethod _method = HttpMethod.Get;
    
    private readonly Dictionary<string, string> _headers = new Dictionary<string, string>();

    private readonly HttpClient _client;
    private readonly ISerializer _serializer;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="client"></param>
    /// <param name="serializer"></param>
    public HttpRequestBuilder(HttpClient client, ISerializer serializer)
    {
        _client = client;
        _serializer = serializer;
    }

    #region IHttpRequestCanSetRouting

    /// <inheritdoc />
    public IHttpRequestCanRequest WithUrl(HttpMethod method, string url)
    {
        _method = method;
        _url = url;

        return this;
    }

    /// <inheritdoc />
    public IHttpRequestCanRequest WithGet(string url) => WithUrl(HttpMethod.Get, url);

    /// <inheritdoc />
    public IHttpRequestCanRequest WithPost(string url) => WithUrl(HttpMethod.Post, url);

    /// <inheritdoc />
    public IHttpRequestCanRequest WithPut(string url) => WithUrl(HttpMethod.Put, url);

    /// <inheritdoc />
    public IHttpRequestCanRequest WithPatch(string url) => WithUrl(HttpMethod.Patch, url);

    /// <inheritdoc />
    public IHttpRequestCanRequest WithDelete(string url) => WithUrl(HttpMethod.Delete, url);
    #endregion

    #region IHttpRequestCanRequest
    /// <inheritdoc />
    public IHttpRequestCanRequest WithHeaders(IDictionary<string, string> headers)
    {
        foreach(var header in headers)
        {
           _headers.Add(header.Key, header.Value);
        }

        return this;
    }

    /// <inheritdoc />
    public IHttpRequestCanRequest WithHeader(string key, string value)
    {
        _headers.Add(key, value);

        return this;
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public async Task<HttpResponseMessage> RequestAsync()
    {
        using var requestMessage = new HttpRequestMessage(_method, _url);

        foreach (var header in _headers)
        {
            requestMessage.Headers.Add(header.Key, header.Value);
        }

        return await _client.SendAsync(requestMessage);
    }

    /// <inheritdoc />
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
