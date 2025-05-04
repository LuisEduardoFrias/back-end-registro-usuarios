using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Infraestructure.Insterface
{

    public interface IRepository<T> where T : class
    {
        IQueryable<T> Get();

        Task<bool> PostAsync(T user);

        Task<bool> PutAsync(T user);
    }
}
