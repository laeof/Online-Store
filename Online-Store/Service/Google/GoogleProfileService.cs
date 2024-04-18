using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Helpers;
using Online_Store.Service.Google;

namespace Online_Store.Service
{
    public class GoogleProfileService
    {
        private readonly HttpClientHelper _httpClientHelper;
        private readonly DataManager _dataManager;
        private readonly string _apiUserInfoEndpoint = "https://www.googleapis.com/oauth2/v1/userinfo?alt=json";
        public GoogleProfileService(HttpClientHelper httpClientHelper,
                                    DataManager dataManager)
        {
            _httpClientHelper = httpClientHelper;
            _dataManager = dataManager;
        }
        public async Task<GoogleUser> GetUserInfo(string access_token)
        {

            var queryParams = new Dictionary<string, string>
            {

            };

            var info = await _httpClientHelper.SendGetRequest<dynamic>(_apiUserInfoEndpoint, queryParams, access_token);

            var user = new GoogleUser
            {
                id = info.id,
                name = info.name,
                given_name = info.given_name,
                family_name = info.name,
                link = info.link,
                picture = info.picture,
                gender = info.gender,
                locale = info.locale,
            };

            return user;
        }
        public async Task<GoogleUser> UserAsync(string access_token)
        {
            var googleUser = await GetUserInfo(access_token);

            return googleUser;
        }
        public async Task<Guid> GetUserIdAsync(GoogleUser googleUser)
        {
            var user = await _dataManager.Users.GetUserByGoogleIdAsync(googleUser.id);

            return user.Id;
        }
    }
}