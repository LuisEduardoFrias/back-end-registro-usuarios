using System.ComponentModel.DataAnnotations;

namespace UserRegistration.Domain.Dtos.user
{
    public class UpdateUserDto : CreateUserDto
    {
        [Required]
        public string Id { get; set; }
    }
}
