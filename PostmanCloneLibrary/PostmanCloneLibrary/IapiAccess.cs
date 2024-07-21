
namespace PostmanCloneLibrary
{
    public interface IapiAccess
    {
        Task<string> CallApiAsync(string apiId, HttpAction action = HttpAction.GET, HttpContent? content = null);
        bool IsValidUrl(string url);
    }
}