using Microsoft.AspNetCore.Mvc;
using UserRegistration.Application;
using UserRegistration.Domin.Dtos;
using UserRegistration.Domin.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back_end_registro_usuarios.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {


        private readonly UserApplication _userApplication;

        public UserController(UserApplication userApplication)
        {
            _userApplication = userApplication;
        }


        [HttpGet]
        public IEnumerable<ShowUserDto> Get()
        {
            return _userApplication.Get();
        }


        [HttpPost]
        public async Task<ActionResult> Port(CreateUserDto userDto)
        {
            bool result = await _userApplication.PostAsync(userDto);

            return result ? NoContent() : throw new System.Exception("An error occurred while saving the record.");
        }
    }
}
