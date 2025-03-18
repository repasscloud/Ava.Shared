using System.ComponentModel.DataAnnotations;

namespace Ava.Shared.Models.DTOs
{
    public class EmailRequestDto
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
    }
}
