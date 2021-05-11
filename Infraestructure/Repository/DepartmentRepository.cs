using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UserRegistration.Domain.Entites;
using UserRegistration.Infraestructure.DataAccess;
using UserRegistration.Infraestructure.Insterface;

namespace UserRegistration.Infraestructure.Repository
{
    public class DepartmentRepository : BaseRepository, IRepository<Department>
    {
        public DepartmentRepository(UserRegistrationDbContext context) : base(context)
        { }

        public IQueryable<Department> Get()
        {
            return context.Departments;
        }

        public async Task<bool> PostAsync(Department department)
        {
            context.Departments.Add(department);

            return (await context.SaveChangesAsync()) >= 1;
        }

        public async Task<bool> PutAsync(Department department)
        {
            Department departmentDb = await context.Departments.FirstOrDefaultAsync(x => x.Code == department.Code);

            departmentDb = department;

            return (await context.SaveChangesAsync()) >= 1;
        }
    }
}
