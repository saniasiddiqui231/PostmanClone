

using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace PostmanCloneLibrary
{
    public class apiAccess : IapiAccess
    {
        private readonly HttpClient httpClient = new();
        public async Task<string> CallApiAsync(string apiId,
            HttpAction action = HttpAction.GET,
            HttpContent? content = null
            )
        {
            HttpResponseMessage response = null;
            switch (action)
            {
                case HttpAction.GET:
                    response = await httpClient.GetAsync(apiId);
                    break;

                case HttpAction.POST:
                    response = await httpClient.PostAsync(apiId, content);
                    break;

                case HttpAction.PUT:
                    response = await httpClient.PutAsync(apiId, content);
                    break;

                case HttpAction.DELETE:
                    response = await httpClient.DeleteAsync(apiId);
                    break;
                case HttpAction.PATCH:
                    var request = new HttpRequestMessage(new HttpMethod("PATCH"), apiId) { Content = content };
                    response = await httpClient.SendAsync(request);
                    break;

                default:
                    throw new NotSupportedException($"HTTP action {action} is not supported");
            }
            //var response = await httpClient.GetAsync(apiId);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var jsonText = JsonSerializer.Deserialize<JsonElement>(json);
                string readableJson = JsonSerializer.Serialize(jsonText,
                        new JsonSerializerOptions { WriteIndented = true });
                
                return readableJson;
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }
        public bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }

            if (Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput))
            {
                return uriOutput.Scheme == Uri.UriSchemeHttp || uriOutput.Scheme == Uri.UriSchemeHttps;
            }

            return false;
        }

    }
}
