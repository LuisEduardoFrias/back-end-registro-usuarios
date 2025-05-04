using AutoMapper;
using UserRegistration.Domain.Dtos.department;
using UserRegistration.Domain.Dtos.user;
using UserRegistration.Domain.Entites;

namespace UserRegistration.Api.MapConfiguration
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<User, ShowUserDto>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentDto, Department>();
        }
    }
}
