using System.Linq;
using System.Threading.Tasks;
//
using Domin.Entites;
using Infraestructure.DataAccess;
//

namespace Infraestructure.Repository
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(UserRegistrationDbContext context) : base(context)
        {}

        public IQueryable<User> Get()
        {
            return Context.Users;
        }

        public async Task<bool> Post(User user)
        {
            Context.Users.Add(user);

            return (await Context.SaveChangesAsync()) >= 1;
        }
    }
}
