using ApplicationContextDB.Contexts;
using DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntitiesRepositories
{
    public class ReviewEntityRepository
    {
        private ContextReviewDB context;

        public ReviewEntityRepository(ContextReviewDB context) =>
            this.context = context;

        public async Task<List<ReviewEntity>?> GetReviewsByIdAsync(int id) =>
            await context
            .Reviews
            .Where(x => x.IdHome == id)
            .ToListAsync();

        public async Task AddReviewAsync(ReviewEntity entity)
        {
            context.Reviews.Add(entity);

            await context.SaveChangesAsync();
        }
    }
}
