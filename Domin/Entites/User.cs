using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserRegistration.Domain.Entites
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "char(1)")]
        [Required]
        public string Gender { get; set; }

        [Column(TypeName = "char(11)")]
        [Required]
        public string IdentificationCard { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public DateTime BirthDay { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Position { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string ImmediateSupervisor { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
