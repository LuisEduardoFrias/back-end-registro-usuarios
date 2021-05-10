using System.Linq;
using System.Threading.Tasks;
//
using Domin.Entites;
using Infraestructure.DataAccess;
using Infraestructure.Insterface;
//

namespace Infraestructure.Repository
{
    public class DepartamentRepository : BaseRepository, IRepository<Department>
    {
        public DepartamentRepository(UserRegistrationDbContext context) : base(context)
        {}

        public IQueryable<Department> Get()
        {
            return Context.Departments;
        }

        public async Task<bool> Post(Department department)
        {
            Context.Departments.Add(department);

            return (await Context.SaveChangesAsync()) >= 1;
        }
    }
}
