using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.Dtos
{
    public class DepartmentDto
    {
        [Required]
        public int Code { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
