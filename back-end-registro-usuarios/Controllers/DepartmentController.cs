using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserRegistration.Application;
using UserRegistration.Domin.Dtos;

namespace UserRegistration.Api.Controllers
{
    [ApiController]
    [Route("api/departement")]
    public class DepartmentController : Controller
    {

        private readonly DepartmentApplication _departmaentApplication;

        public DepartmentController(DepartmentApplication departmaentApplication)
        {
            _departmaentApplication = departmaentApplication;
        }


        [HttpGet]
        public IEnumerable<DepartmentDto> Get()
        {
            return _departmaentApplication.Get();
        }


        [HttpPost]
        public async Task<ActionResult> Port(DepartmentDto departmentDto)
        {
            bool result = await _departmaentApplication.PostAsync(departmentDto);

            return result ? NoContent() : throw new System.Exception("An error occurred while saving the record.");
        }
    }
}
