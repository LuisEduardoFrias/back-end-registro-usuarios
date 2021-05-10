using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
//
using Domin.Dtos;
using Domin.Entites;
using Infraestructure.Insterface;
//

namespace back_end_registro_usuarios.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {

        private readonly IRepository<User> _Repository;
        private readonly IMapper _Mapper;

        public UserController(IRepository<User> repository, IMapper mapper)
        {
            _Repository = repository;
            _Mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<ShowUserDto> Get()
        {
            return _Mapper.Map<IEnumerable<ShowUserDto>>(_Repository.Get());
        }


        [HttpPost]
        public async Task<ActionResult> Port(CreateUserDto userDto)
        {
            bool result = await _Repository.Post(_Mapper.Map<User>(userDto));

            return result ? NoContent() : throw new System.Exception("An error occurred while saving the record.");
        }
    }
}
