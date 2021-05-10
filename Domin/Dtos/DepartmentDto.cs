using System.ComponentModel.DataAnnotations;

namespace UserRegistration.Domin.Dtos
{
    public class DepartmentDto
    {
        [Required]
        public int Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
