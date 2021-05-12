using UserRegistration.Domain.Entites;
using UserRegistration.Infraestructure.DataAccess;
using UserRegistration.Infraestructure.Insterface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Infraestructure.Repository
{
    public class UserRepository : BaseRepository, IRepository<User>
    {
        public UserRepository(UserRegistrationDbContext context) : base(context)
        {}

        public IQueryable<User> Get()
        {
            return context.Users.Include(x => x.Department);
        }

        public async Task<bool> PostAsync(User user)
        {
            context.Users.Add(user);

            return (await context.SaveChangesAsync()) >= 1;
        }
        
        public async Task<bool> PutAsync(User user)
        {
            context.Users.Update(user);

            return (await context.SaveChangesAsync()) == 1;
        }
    }
}
