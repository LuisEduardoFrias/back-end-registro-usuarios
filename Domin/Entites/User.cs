using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.Entites
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
        public string LasName { get; set; }

        [Column(TypeName = "char(1)")]
        [Required]
        public string Gender { get; set; }

        [Column(TypeName = "char(11)")]
        [Required]
        public string IdentificationCard { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public DateTime DateBirth { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Position { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string ImmediateSupervisor { get; set; }

        [Required]
        public int Department { get; set; }

        [ForeignKey("Department")]
        public ICollection<Department> Departments { get; set; }
    }
}
