using UserRegistration.Domin.Dtos;

namespace UserRegistration.Domin.Dtos
{
    public class ShowUserDto : CreateUserDto
    {
        public int Id { get; set; }

        public string DepartmentName => Department.Name;
    }
}
