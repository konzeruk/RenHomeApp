using ApplicationContextDB.Contexts;
using DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntitiesRepositories
{
    public class AuthEntityRepository
    {
        private ContextAuthDB context;

        public AuthEntityRepository(ContextAuthDB context) =>
            this.context = context;

        public async Task<UserEntity?> GetUserAsync(string login, string password) =>
            await context
            .Auth
            .Where(x => x.Login == login && x.Password == password)
            .FirstOrDefaultAsync();
    }
}
