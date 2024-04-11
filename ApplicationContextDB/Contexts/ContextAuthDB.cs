using DTO.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApplicationContextDB.Contexts
{
    public class ContextAuthDB : DbContext
    {
        private string urlServer;

        public DbSet<UserEntity> Auth { get; set; } = null!;

        public ContextAuthDB(IConfiguration сonfiguration, bool create = false)
        {
            urlServer = сonfiguration.GetConnectionString(Constants.dbAuth)!;

            if (create)
                Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(urlServer);
    }
}
