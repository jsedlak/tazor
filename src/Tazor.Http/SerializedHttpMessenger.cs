using Newtonsoft.Json;
using System.Net.Http;
using Tazor.Serialization;

namespace Tazor.Http;

public class SerializedHttpMessenger : IHttpMessenger
{
    private readonly HttpClient _client;
    private readonly ISerializer _serializer;

    public SerializedHttpMessenger(HttpClient client, ISerializer serializer)
    {
        _client = client;
        _serializer = serializer;
    }

    public async Task<TModel?> GetSerializedAsync<TModel>(string requestUri, IDictionary<string, string>? headers = null)
    {
        // var stringResult = await _client.GetStringAsync(requestUri);
        using var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);

        if(headers != null)
        {
            foreach(var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }
        }

        var response = await _client.SendAsync(requestMessage);
        var responseJson = await response.Content.ReadAsStringAsync();

        return _serializer.Deserialize<TModel?>(responseJson);
    }

    public async Task<HttpResponseMessage> PostSerializedAsync<TModel>(string requestUri, TModel model, IDictionary<string, string>? headers = null)
    {
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        var jsonData = _serializer.Serialize(model);
        var content = new StringContent(jsonData);

        if (headers != null)
        {
            foreach (var header in headers)
            {
                content.Headers.Add(header.Key, header.Value);
            }
        }

        return await _client.PostAsync(requestUri, content);
    }

    public async Task<HttpResponseMessage> PutSerializedAsync<TModel>(string requestUri, TModel model, IDictionary<string, string>? headers = null)
    {
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        var jsonData = _serializer.Serialize(model);
        var content = new StringContent(jsonData);

        if (headers != null)
        {
            foreach (var header in headers)
            {
                content.Headers.Add(header.Key, header.Value);
            }
        }

        return await _client.PutAsync(requestUri, content);
    }

    public async Task<HttpResponseMessage> DeleteSerializedAsync(string requestUri, IDictionary<string, string>? headers = null)
    {
        using var requestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);

        if (headers != null)
        {
            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }
        }

        var response = await _client.SendAsync(requestMessage);
        return response;
    }

    #region IHttpRequestCanSetRouting
    public IHttpRequestCanRequest WithUrl(HttpMethod method, string url)
    {
        return new HttpRequestBuilder(_client, _serializer).WithUrl(method, url);
    }

    public IHttpRequestCanRequest WithGet(string url) => WithUrl(HttpMethod.Get, url);

    public IHttpRequestCanRequest WithPost(string url) => WithUrl(HttpMethod.Post, url);

    public IHttpRequestCanRequest WithPut(string url) => WithUrl(HttpMethod.Put, url);

    public IHttpRequestCanRequest WithPatch(string url) => WithUrl(HttpMethod.Patch, url);

    public IHttpRequestCanRequest WithDelete(string url) => WithUrl(HttpMethod.Delete, url);
    #endregion
}
