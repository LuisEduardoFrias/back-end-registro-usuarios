using AutoMapper;
using UserRegistration.Infraestructure.Insterface;

namespace UserRegistration.Application
{
    public class BaseApplication<T> where T : class
    {
        protected readonly IRepository<T> repository;
        protected readonly IMapper mapper;

        public BaseApplication(IRepository<T> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

    }
}
