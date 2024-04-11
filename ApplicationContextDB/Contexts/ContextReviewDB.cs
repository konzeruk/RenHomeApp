using DTO.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApplicationContextDB.Contexts
{
    public class ContextReviewDB : DbContext
    {
        private string urlServer;

        public DbSet<ReviewEntity> Reviews { get; set; } = null!;

        public ContextReviewDB(IConfiguration сonfiguration, bool create = false)
        {
            urlServer = сonfiguration.GetConnectionString(Constants.dbReview)!;

            if (create)
                Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(urlServer);
    }
}
