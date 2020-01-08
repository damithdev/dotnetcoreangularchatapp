using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(12,MinimumLength=8,ErrorMessage = "Password length should be between 8 and 12")]
        public string Password { get; set; }
    }
}
