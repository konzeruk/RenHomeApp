using DTO.Entities;
using DTO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApplicationContextDB.Contexts
{
    public class ContextHomeDB : DbContext
    {
        private string urlServer;

        public DbSet<HomeEntity> Homes { get; set; } = null!;
        public DbSet<ReservationEntity> Reservations { get; set; } = null!;

        public ContextHomeDB(IConfiguration сonfiguration, bool create = false)
        {
            urlServer = сonfiguration.GetConnectionString(Constants.dbHome)!;

            if (create)
                Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(urlServer);
    }
}
