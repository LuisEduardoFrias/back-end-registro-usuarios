namespace UserRegistration.Domain.Dtos.user
{
    public class ShowUserDto : CreateUserDto
    {
        public int Id { get; set; }

        public string DepartmentName => Department.Name;
    }
}
