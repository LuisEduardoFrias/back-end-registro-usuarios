using UserRegistration.Domin.Entites;
using Microsoft.EntityFrameworkCore;

namespace UserRegistration.Infraestructure.DataAccess
{
    public class UserRegistrationDbContext : DbContext
    {

        #region Properties

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }

        #endregion

        public UserRegistrationDbContext(DbContextOptions<UserRegistrationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
