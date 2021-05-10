using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LasName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string IdentificationCard { get; set; }

        [Required]
        public DateTime DateBirth { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string ImmediateSupervisor { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public DepartmentDto Department { get; set; }
    }

    public class ShowUserDto : CreateUserDto
    {
        public int Id { get; set; }

        public string DepartmentName => Department.Name;
    }
}
