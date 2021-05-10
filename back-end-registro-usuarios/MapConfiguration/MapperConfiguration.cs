using AutoMapper;
using UserRegistration.Domin.Dtos;
using UserRegistration.Domin.Entites;

namespace UserRegistration.Api.MapConfiguration
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<User, ShowUserDto>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentDto, Department>();
        }
    }
}
