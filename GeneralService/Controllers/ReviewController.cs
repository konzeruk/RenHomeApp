using DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GeneralService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly ILogger logger;

        private readonly HttpClient httpClient;

        private const string nameService = "Review";
        private readonly string urlService;

        public ReviewController(ILogger logger, IConfiguration configuration)
        {
            this.logger = logger;
            urlService = configuration[$"ServiceUrl:{nameService}"]!;

            httpClient = new HttpClient();
        }


        [HttpGet("getReviewsById/{id:int}")]
        public async Task<ActionResult> GetReviewsByIdAsync([FromRoute] int id)
        {
            logger.LogInformation($"{nameof(HomeController)}: request /getReviewsById");

            var response = await httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri($"{urlService}/api/Review/getReviewsById/{id}"),
                Method = HttpMethod.Get,
                Content = null
            });

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok(JsonConvert.DeserializeObject<List<ReviewModel>>(await response.Content.ReadAsStringAsync()));

            return Problem(await response.Content.ReadAsStringAsync(), statusCode: 500);
        }

        [HttpPost("postReview")]
        public async Task<ActionResult> PostReviewAsync([FromBody] ReviewModel review)
        {
            logger.LogInformation($"{nameof(HomeController)}: request /postReview");

            var response = await httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri($"{urlService}/api/Review/postReview"),
                Method = HttpMethod.Post,
                Content = JsonContent.Create(review)
            });

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok();

            return Problem(await response.Content.ReadAsStringAsync(), statusCode: 500);
        }
    }
}
