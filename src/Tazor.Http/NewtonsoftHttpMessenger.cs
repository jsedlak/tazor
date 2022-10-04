using Newtonsoft.Json;

namespace Tazor.Http;

public class NewtonsoftHttpMessenger : IHttpMessenger
{
    private readonly HttpClient _client;
    private readonly JsonSerializerSettings _settings;

    public NewtonsoftHttpMessenger(HttpClient client, JsonSerializerSettings settings)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
        _settings = settings ?? throw new ArgumentNullException(nameof(settings));
    }

    public async Task<TModel?> GetAsync<TModel>(string requestUri)
    {
        var stringResult = await _client.GetStringAsync(requestUri);
        return JsonConvert.DeserializeObject<TModel>(stringResult, _settings);
    }

    public async Task<HttpResponseMessage> PostAsync<TModel>(string requestUri, TModel model)
    {
        var jsonData = JsonConvert.SerializeObject(model, _settings);
        var content = new StringContent(jsonData);

        return await _client.PostAsync(requestUri, content);
    }

    public async Task<HttpResponseMessage> PutAsync<TModel>(string requestUri, TModel model)
    {
        var jsonData = JsonConvert.SerializeObject(model, _settings);
        var content = new StringContent(jsonData);

        return await _client.PutAsync(requestUri, content);
    }

    public async Task<HttpResponseMessage> DeleteAsync(string requestUri)
    {
        return await _client.DeleteAsync(requestUri);
    }
}