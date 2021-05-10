using System.Linq;
using System.Threading.Tasks;

namespace Infraestructure.Insterface
{

    public interface IRepository<T> where T : class
    {
        IQueryable<T> Get();

        Task<bool> Post(T user);
    }
}
