using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UserRegistration.Domain.Dtos.department;

namespace UserRegistration.Domain.Dtos.user
{
    public class CreateUserDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string IdentificationCard { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string ImmediateSupervisor { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public DepartmentDto Department { get; set; }
    }
}
