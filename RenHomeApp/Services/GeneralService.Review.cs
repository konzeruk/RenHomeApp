using DTO.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace RenHomeApp.Services
{
    public static partial class GeneralService
    {
        public class Review
        {
            private const string urlController = @"api/review";
            private readonly HttpClient httpClient;

            public Review() =>
                httpClient = new HttpClient();

            public async Task<List<ReviewModel>?> GetReviewsByIdAsync(int id)
            {
                var response = await httpClient.SendAsync(new HttpRequestMessage
                {
                    RequestUri = new Uri($"{BaseUrl}/{urlController}/getReviewsById/{id}"),
                    Method = HttpMethod.Get,
                    Content = null
                });

                return (response.StatusCode == System.Net.HttpStatusCode.OK) ? JsonConvert.DeserializeObject<List<ReviewModel>>(await response.Content.ReadAsStringAsync()) : null;
            }

            public async Task<bool> PostReviewAsync(ReviewModel review)
            {
                var response = await httpClient.SendAsync(new HttpRequestMessage
                {
                    RequestUri = new Uri($"{BaseUrl}/{urlController}/postReview"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(review)
                });

                return (response.StatusCode == System.Net.HttpStatusCode.OK) ? true : false;
            }
        }
    }
}
