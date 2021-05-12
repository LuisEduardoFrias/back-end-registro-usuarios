using System.ComponentModel.DataAnnotations;

namespace UserRegistration.Domain.Dtos.user
{
    public class UpdateUserDto : CreateUserDto
    {
        [Required]
        public int Id { get; set; }
    }
}
