
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using Online_Store.Helpers;

namespace Online_Store.Service
{
    public class GoogleOAuthService
    {
        private readonly HttpClientHelper _httpClientHelper;
        private readonly string _clientId;
        private readonly string _clientSecret;
        public GoogleOAuthService(HttpClientHelper httpClientHelper,
                                  string client_id,
                                  string client_secret)
        {
            _httpClientHelper = httpClientHelper;
            _clientId = client_id;
            _clientSecret = client_secret;
        }
        public string GenerateOAuthRequestUrl(string scope, string redirectUrl, string codeChallenge)
        {
            var oAuthServerEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";

            var queryParams = new Dictionary<string, string> {
                { "client_id", _clientId },
                { "redirect_uri", redirectUrl },
                { "response_type", "code" },
                { "scope", scope },
                { "code_challenge", codeChallenge },
                { "code_challenge_method", "S256"},
                { "access_type", "offline"}
            };

            var url = QueryHelpers.AddQueryString(oAuthServerEndpoint, queryParams);

            return url;
        }
        public async Task<TokenResult> ExchangeCodeOnTokenAsync(string code, string codeVerifier, string redirectUrl)
        {
            var tokenEndpoint = "https://oauth2.googleapis.com/token";

            var authParams = new Dictionary<string, string> {
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
                { "code", code },
                { "code_verifier", codeVerifier },
                { "grant_type", "authorization_code" },
                { "redirect_uri", redirectUrl},
            };

            var tokenResult = await _httpClientHelper.SendPostRequest<TokenResult>(tokenEndpoint, authParams);
            return tokenResult;
        }
        public object RefreshToken()
        {
            throw new NotImplementedException();
        }
    }
}