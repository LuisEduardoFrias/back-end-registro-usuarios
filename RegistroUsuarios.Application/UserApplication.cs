using AutoMapper;
using UserRegistration.Domin.Dtos;
using UserRegistration.Domin.Entites;
using UserRegistration.Infraestructure.Insterface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UserRegistration.Application
{
    public class UserApplication : BaseApplication<User>
    {
        public UserApplication(IRepository<User> repository, IMapper mapper) : base(repository, mapper)
        {
        }


        public IEnumerable<ShowUserDto> Get()
        {
            return mapper.Map<IEnumerable<ShowUserDto>>(repository.Get());
        }


        public async Task<bool> PostAsync(CreateUserDto userDto)
        {
            return await repository.PostAsync(mapper.Map<User>(userDto));
        }
    }
}
