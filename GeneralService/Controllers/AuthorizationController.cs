using DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GeneralService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorizationController : ControllerBase
    {
        private readonly ILogger logger;

        private readonly HttpClient httpClient;

        private const string nameService = "Auth";
        private readonly string urlService;

        public AuthorizationController(ILogger logger, IConfiguration configuration)
        {
            this.logger = logger;
            urlService = configuration[$"ServiceUrl:{nameService}"]!;

            httpClient = new HttpClient();
        }


        [HttpGet("getUser")]
        public async Task<ActionResult> GetUser([FromBody] UserModel user)
        {
            logger.LogInformation($"{nameof(AuthorizationController)}: request /getUser");

            var response = await httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri($"{urlService}/Auth/getUser"),
                Method = HttpMethod.Get,
                Content = JsonContent.Create(user)
            });

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok(JsonConvert.DeserializeObject<UserModelResponse>(await response.Content.ReadAsStringAsync()));

            return Problem(await response.Content.ReadAsStringAsync(), statusCode: 500);
        }
    }
}
