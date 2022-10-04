namespace Tazor.Http;

public interface IHttpMessenger
{
    Task<TModel?> GetAsync<TModel>(string requestUri);

    Task<HttpResponseMessage> PostAsync<TModel>(string requestUri, TModel model);

    Task<HttpResponseMessage> PutAsync<TModel>(string requestUri, TModel model);

    Task<HttpResponseMessage> DeleteAsync(string requestUri);
}
