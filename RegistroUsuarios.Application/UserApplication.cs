using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserRegistration.Domain.Dtos.user;
using UserRegistration.Domain.Entites;
using UserRegistration.Infraestructure.Insterface;

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


        public async Task<bool> PutAsync(UpdateUserDto userDto)
        {
            return await repository.PutAsync(mapper.Map<User>(userDto));
        }
    }
}
