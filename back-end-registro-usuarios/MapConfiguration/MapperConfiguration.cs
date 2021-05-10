﻿using AutoMapper;
using UserRegistration.Domin.Dtos;
using UserRegistration.Domin.Entites;

namespace back_end_registro_usuarios.MapConfiguration
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            //User
            CreateMap<CreateUserDto, User>();
            CreateMap<User, ShowUserDto>();

            //Despartament
            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentDto, Department>();
        }
    }
}
