using DTO.Extensions;
using DTO.Models;
using EntitiesRepositories;
using Microsoft.AspNetCore.Mvc;

namespace HomeStorageService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeStorageController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly HomeEntityRepository repository;

        public HomeStorageController(ILogger logger, HomeEntityRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        [HttpGet("getAllHomes")]
        public async Task<ActionResult> GetAllHomesAsync()
        {
            try
            {
                logger.LogInformation($"Request getAllHomes");

                var homes = await repository.GetAllHomesAsync();

                var response = homes.ToHomesModel();

                return Ok(value: response);
            }
            catch(Exception ex)
            {
                logger.LogInformation(ex.Message);

                return Problem(ex.Message, statusCode: 500);
            }
        }

        [HttpGet("getHomeById/{id:int}")]
        public async Task<ActionResult> GetHomeByIdAsync([FromRoute] int id)
        {
            try
            {
                logger.LogInformation($"Request getHomeById");

                var home = await repository.GetHomeByIdAsync(id);

                var response = (home != null) ? home.ToHomeModel() : null;

                return Ok(value: response);
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);

                return Problem(ex.Message, statusCode: 500);
            }
        }

        [HttpPost("postHome")]
        public async Task<ActionResult> PostHomeAsync([FromBody] HomeModel home)
        {
            try
            {
                logger.LogInformation($"Request postHome");

                await repository.AddHomeAsync(home.ToHomeEntity());

                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);

                return Problem(ex.Message, statusCode: 500);
            }
        }

        [HttpPut("putHome")]
        public async Task<ActionResult> PutHomeAsync([FromBody] HomeModel home)
        {
            try
            {
                logger.LogInformation($"Request putHome");

                await repository.UpdateHomeAsync(home.ToHomeEntity());

                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);

                return Problem(ex.Message, statusCode: 500);
            }
        }
    }
}
