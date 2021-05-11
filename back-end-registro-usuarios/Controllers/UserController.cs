using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserRegistration.Application;
using UserRegistration.Domain.Dtos.user;

namespace UserRegistration.Api.Controllers
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
        public async Task<ActionResult> PostAsync(CreateUserDto userDto)
        {
            bool result = await _userApplication.PostAsync(userDto);

            return result ? NoContent() : throw new System.Exception("An error occurred while saving the record.");
        }


        [HttpPut]
        public async Task<ActionResult> PutAsync(UpdateUserDto userDto)
        {
            bool result = await _userApplication.PutAsync(userDto);

            return result ? NoContent() : throw new System.Exception("An error occurred while saving the record.");
        }
    }
}
