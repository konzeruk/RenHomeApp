using ApplicationContextDB.Contexts;
using DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntitiesRepositories
{
    public class HomeEntityRepository
    {
        private ContextHomeDB context;

        public HomeEntityRepository(ContextHomeDB context) =>
            this.context = context;

        public async Task<List<HomeEntity>> GetAllHomesAsync() =>
            await context
            .Homes
            .Include(x => x.Reservations)
            .ToListAsync();

        public async Task<HomeEntity?> GetHomeByIdAsync(int id) =>
            await context
            .Homes
            .Where(x => x.Id == id)
            .Include(x => x.Reservations)
            .FirstOrDefaultAsync();

        public async Task AddHomeAsync(HomeEntity home)
        {
            context.Homes.Add(home);

            await context.SaveChangesAsync();
        }

        public async Task UpdateHomeAsync(HomeEntity home)
        {
            context.Homes.Update(home);

            await context.SaveChangesAsync();
        }
    }
}
