using Domin.Entites;
using Infraestructure.Insterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back_end_registro_usuarios.Controllers
{
    [ApiController]
    [Route("api/departement")]
    public class DepartamentController : Controller
    {

        private readonly IRepository<Department> Repository;


        public DepartamentController(IRepository<Department> repository)
        {
            Repository = repository;
        }


        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return Repository.Get();
        }


        [HttpPost]
        public async Task<ActionResult> Port(Department department)
        {
            bool result = await Repository.Post(department);

            return result ? NoContent() : throw new System.Exception("An error occurred while saving the record.");
        }
    }
}
