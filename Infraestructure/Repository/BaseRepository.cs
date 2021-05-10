using Infraestructure.DataAccess;

namespace Infraestructure.Repository
{
    public class BaseRepository
    {
        public readonly UserRegistrationDbContext Context;

        public BaseRepository(UserRegistrationDbContext context)
        {
            Context = context;
        }
    }
}
