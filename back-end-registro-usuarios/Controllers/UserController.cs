using Domin.Entites;
using Infraestructure.Insterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back_end_registro_usuarios.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {

        private readonly IRepository<User> Repository;


        public UserController(IRepository<User> repository)
        {
            Repository = repository;
        }


        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Repository.Get();
        }


        [HttpPost]
        public async Task<ActionResult> Port(User user)
        {
            bool result = await Repository.Post(user);

            return result ? NoContent() : throw new System.Exception("An error occurred while saving the record.");
        }
    }
}
