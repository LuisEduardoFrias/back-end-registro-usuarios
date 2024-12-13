using System.ComponentModel.DataAnnotations;

namespace UserRegistration.Domain.Dtos.department
{
    public class DepartmentDto
    {
        [Required]
        public int Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
