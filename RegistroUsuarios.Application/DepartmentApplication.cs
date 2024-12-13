using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserRegistration.Domain.Dtos.department;
using UserRegistration.Domain.Entites;
using UserRegistration.Infraestructure.Insterface;

namespace UserRegistration.Application
{
    public class DepartmentApplication : BaseApplication<Department>
    {
        public DepartmentApplication(IRepository<Department> repository, IMapper mapper) : base(repository, mapper)
        {
        }


        public IEnumerable<DepartmentDto> Get()
        {
            return mapper.Map<IEnumerable<DepartmentDto>>(repository.Get());
        }


        public async Task<bool> PostAsync(DepartmentDto departmentDto)
        {
            return await repository.PostAsync(mapper.Map<Department>(departmentDto));
        }


        public async Task<bool> PutAsync(DepartmentDto departmentDto)
        {
            return await repository.PutAsync(mapper.Map<Department>(departmentDto));
        }
    }
}
