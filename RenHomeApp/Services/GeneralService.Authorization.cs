using DTO.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace RenHomeApp.Services
{
    public static partial class GeneralService
    {
        public class Authorization
        {
            private const string urlController = @"api/authorization";
            private readonly HttpClient httpClient;

            public Authorization() =>
                httpClient = new HttpClient();

            public async Task<UserModelResponse?> GetUserAsync(string login, string password)
            {
                var user = new UserModel
                {
                    Login = login, 
                    Password = password 
                };

                var response = await httpClient.SendAsync(new HttpRequestMessage
                {   
                    RequestUri = new Uri($"{BaseUrl}/{urlController}/getUser"),
                    Method = HttpMethod.Get,
                    Content = JsonContent.Create(user)
                });

                return (response.StatusCode == System.Net.HttpStatusCode.OK) ? JsonConvert.DeserializeObject<UserModelResponse>(await response.Content.ReadAsStringAsync()) : null;
            }
        }
    }
}
