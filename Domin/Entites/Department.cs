using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserRegistration.Domain.Entites
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Code { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string Name { get; set; }
    }
}
