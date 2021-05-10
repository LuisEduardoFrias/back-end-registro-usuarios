using UserRegistration.Infraestructure.DataAccess;

namespace UserRegistration.Infraestructure.Repository
{
    public class BaseRepository
    {
        public readonly UserRegistrationDbContext context;

        public BaseRepository(UserRegistrationDbContext context)
        {
            this.context = context;
        }
    }
}
