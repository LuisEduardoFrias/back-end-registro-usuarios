using UserRegistration.Domin.Entites;
using UserRegistration.Infraestructure.DataAccess;
using UserRegistration.Infraestructure.Insterface;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Infraestructure.Repository
{
    public class DepartmentRepository : BaseRepository, IRepository<Department>
    {
        public DepartmentRepository(UserRegistrationDbContext context) : base(context)
        {}

        public IQueryable<Department> Get()
        {
            return context.Departments;
        }

        public async Task<bool> PostAsync(Department department)
        {
            context.Departments.Add(department);

            return (await context.SaveChangesAsync()) >= 1;
        }
    }
}
