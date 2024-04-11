using DTO.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Reflection;

namespace RenHomeApp.Services
{
    public static partial class GeneralService
    {
        public class Home
        {
            private const string urlController = @"api/home";
            private readonly HttpClient httpClient;

            public Home() =>
                httpClient = new HttpClient();

            public async Task<List<HomeModel>?> GetAllHomesAsync()
            {
                var response = await httpClient.SendAsync(new HttpRequestMessage
                {
                    RequestUri = new Uri($"{BaseUrl}/{urlController}/getAllHomes"),
                    Method = HttpMethod.Get,
                    Content = null
                });

                return (response.StatusCode == System.Net.HttpStatusCode.OK) ? JsonConvert.DeserializeObject<List<HomeModel>>(await response.Content.ReadAsStringAsync()) : null;
            }

            public async Task<HomeModel?> GetHomeByIdAsync(int id)
            {
                var response = await httpClient.SendAsync(new HttpRequestMessage
                {
                    RequestUri = new Uri($"{BaseUrl}/{urlController}/getHomeById/{id}"),
                    Method = HttpMethod.Get,
                    Content = null
                });

                return (response.StatusCode == System.Net.HttpStatusCode.OK) ? JsonConvert.DeserializeObject<HomeModel>(await response.Content.ReadAsStringAsync()) : null;
            }

            public async Task<bool> PostHomeAsync(HomeModel home)
            {
                var response = await httpClient.SendAsync(new HttpRequestMessage
                {
                    RequestUri = new Uri($"{BaseUrl}/{urlController}/postHome"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(home)
                });

                return (response.StatusCode == System.Net.HttpStatusCode.OK) ? true : false;
            }

            public async Task<bool> PutHomeAsync(HomeModel home)
            {
                var response = await httpClient.SendAsync(new HttpRequestMessage
                {
                    RequestUri = new Uri($"{BaseUrl}/{urlController}/putHome"),
                    Method = HttpMethod.Put,
                    Content = JsonContent.Create(home)
                });

                return (response.StatusCode == System.Net.HttpStatusCode.OK) ? true : false;
            }
        }
    }
}
