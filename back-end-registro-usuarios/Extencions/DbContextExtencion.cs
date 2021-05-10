using Microsoft.EntityFrameworkCore;
using System.Linq;
using UserRegistration.Api.Enums;
using UserRegistration.Infraestructure.DataAccess;

namespace UserRegistration.Api.Extencions
{

    public static class DbContextExtencion
    {
        public static DBState IsDataFetched(this UserRegistrationDbContext context)
        {
            try
            {
                return (context.Departments.Any()) ? DBState.Fetched : DBState.Unfetched;
            }
            catch
            {
                return DBState.Unmigrated;
            }
        }

        public static void FetchDataBase(this UserRegistrationDbContext context)
        {
            if (IsDataFetched(context) == DBState.Unmigrated)
            {
                context.Database.Migrate();
            }

            if (!context.Departments.Any())
            {
                context.Departments.Add(new UserRegistration.Domin.Entites.Department { Code = 1, Name = "Developer" });
                context.SaveChanges();
            }
        }
    }
}
