using DTO.Extensions;
using DTO.Models;
using EntitiesRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ReviewService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly ReviewEntityRepository repository;

        public ReviewController(ILogger logger, ReviewEntityRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        [HttpGet("getReviewsById/{id:int}")]
        public async Task<ActionResult> GetReviewsByIdAsync([FromRoute]int id)
        {
            try
            {
                logger.LogInformation($"Request getReviewsById");

                var reviews = await repository.GetReviewsByIdAsync(id);

                var response = (reviews != null) ? reviews.ToReviewsModels() : null;

                return Ok(value: response);
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);

                return Problem(ex.Message, statusCode: 500);
            }
        }

        [HttpPost("postReview")]
        public async Task<ActionResult> PostReviewAsync([FromBody] ReviewModel review)
        {
            try
            {
                logger.LogInformation($"Request postReview");

                await repository.AddReviewAsync(review.ToReviewEntity());

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
