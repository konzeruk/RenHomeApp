using DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GeneralService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger logger;

        private readonly HttpClient httpClient;

        private const string nameService = "Home";
        private readonly string urlService;

        public HomeController(ILogger logger, IConfiguration configuration)
        {
            this.logger = logger;
            urlService = configuration[$"ServiceUrl:{nameService}"]!;

            httpClient = new HttpClient();
        }


        [HttpGet("getAllHomes")]
        public async Task<ActionResult> GetAllHomesAsync()
        {
            logger.LogInformation($"{nameof(HomeController)}: request /getAllHomes");

            var response = await httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri($"{urlService}/api/HomeStorage/getAllHomes"),
                Method = HttpMethod.Get,
                Content = null
            });

            var x = JsonConvert.DeserializeObject<List<HomeModel>>(await response.Content.ReadAsStringAsync());

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok(JsonConvert.DeserializeObject<List<HomeModel>>(await response.Content.ReadAsStringAsync()));

            return Problem(await response.Content.ReadAsStringAsync(), statusCode: 500);
        }

        [HttpGet("getHomeById/{id:int}")]
        public async Task<ActionResult> GetHomeByIdAsync([FromRoute] int id)
        {
            logger.LogInformation($"{nameof(HomeController)}: request /getHomeById");

            var response = await httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri($"{urlService}/api/HomeStorage/getHomeById/{id}"),
                Method = HttpMethod.Get,
                Content = null
            });

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok(JsonConvert.DeserializeObject<HomeModel>(await response.Content.ReadAsStringAsync()));

            return Problem(await response.Content.ReadAsStringAsync(), statusCode: 500);
        }

        [HttpPost("postHome")]
        public async Task<ActionResult> PostHomeAsync([FromBody] HomeModel home)
        {
            logger.LogInformation($"{nameof(HomeController)}: request /postHome");

            var response = await httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri($"{urlService}/api/HomeStorage/postHome"),
                Method = HttpMethod.Post,
                Content = JsonContent.Create(home)
            });

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok();

            return Problem(await response.Content.ReadAsStringAsync(), statusCode: 500);
        }

        [HttpPut("putHome")]
        public async Task<ActionResult> PutHomeAsync([FromBody] HomeModel home)
        {
            logger.LogInformation($"{nameof(HomeController)}: request /putHome");

            var response = await httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri($"{urlService}/api/HomeStorage/putHome"),
                Method = HttpMethod.Put,
                Content = JsonContent.Create(home)
            });

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok();

            return Problem(await response.Content.ReadAsStringAsync(), statusCode: 500);
        }
    }
}
