using AutoMapper;
using Domin.Dtos;
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

        private readonly IRepository<Department> _Repository;
        private readonly IMapper _Mapper;

        public DepartamentController(IRepository<Department> repository, IMapper mapper)
        {
            _Repository = repository;
            _Mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<DepartmentDto> Get()
        {
            return _Mapper.Map<IEnumerable<DepartmentDto>>(_Repository.Get());
        }


        [HttpPost]
        public async Task<ActionResult> Port(DepartmentDto departmentDto)
        {
            bool result = await _Repository.Post(_Mapper.Map<Department>(departmentDto));

            return result ? NoContent() : throw new System.Exception("An error occurred while saving the record.");
        }
    }
}
