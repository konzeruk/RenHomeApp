using DTO.Extensions;
using DTO.Models;
using EntitiesRepositories;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly AuthEntityRepository repository;

        public AuthController(ILogger logger, AuthEntityRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        [HttpGet("getUser")]
        public async Task<ActionResult> GetUserAsync([FromBody] UserModel userModel)
        {
            try
            {
                logger.LogInformation($"Request getUser");
                
                var userEntity = await repository.GetUserAsync(userModel.Login, userModel.Password);

                var response = (userEntity != null) ? userEntity.ToUserModelResponse() : null;

                return Ok(value: response);
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);

                return Problem(ex.Message, statusCode: 500);
            }
        }
    }
}
