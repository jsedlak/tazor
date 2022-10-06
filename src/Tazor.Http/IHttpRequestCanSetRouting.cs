namespace Tazor.Http;

public interface IHttpRequestCanSetRouting
{
    IHttpRequestCanRequest WithUrl(HttpMethod method, string url);

    IHttpRequestCanRequest WithGet(string url);

    IHttpRequestCanRequest WithPost(string url);

    IHttpRequestCanRequest WithPut(string url);

    IHttpRequestCanRequest WithPatch(string url);

    IHttpRequestCanRequest WithDelete(string url);
}
