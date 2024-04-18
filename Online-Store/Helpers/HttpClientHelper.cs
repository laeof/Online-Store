using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace Online_Store.Helpers
{
    public class HttpClientHelper
    {
        public async Task<T> SendGetRequest<T>(string endpoint, Dictionary<string, string> queryParams, string accessToken)
        {
            return await SendHttpRequestAsync<T>(HttpMethod.Get, endpoint, accessToken, queryParams);
        }

        public async Task<T> SendPostRequest<T>(string endpoint, Dictionary<string, string> bodyParams)
        {
            var httpContent = new FormUrlEncodedContent(bodyParams);
            return await SendHttpRequestAsync<T>(HttpMethod.Post, endpoint, httpContent: httpContent);
        }

        public async Task SendPutRequest(string endpoint, Dictionary<string, string> queryParams, object body, string accessToken)
        {
            var bodyJson = JsonConvert.SerializeObject(body);
            var httpContent = new StringContent(bodyJson, Encoding.UTF8, "application/json");
            await SendHttpRequestAsync<dynamic>(HttpMethod.Put, endpoint, accessToken, queryParams, httpContent);
        }

        private async Task<T> SendHttpRequestAsync<T>(HttpMethod httpMethod, string endpoint, string accessToken = null, Dictionary<string, string> queryParams = null, HttpContent httpContent = null)
        {
            var url = queryParams != null
                ? QueryHelpers.AddQueryString(endpoint, queryParams)
                : endpoint;

            var request = new HttpRequestMessage(httpMethod, url);

            if (accessToken != null)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }

            if (httpContent != null)
            {
                request.Content = httpContent;
            }

            var httpClient = new HttpClient();
            var response = await httpClient.SendAsync(request);

            var resultJson = await response.Content.ReadAsStringAsync();

            //todo
            //handle the exception

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(resultJson);
            }

            var result = JsonConvert.DeserializeObject<T>(resultJson);
            return result;
        }
    }
}