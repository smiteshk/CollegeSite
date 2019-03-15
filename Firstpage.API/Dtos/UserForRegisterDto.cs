using System.ComponentModel.DataAnnotations;

namespace Firstpage.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]

        public string Username { get; set; }   

        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage ="You Must Specify call different password in it")]
        public string  Password { get; set; }
    }
}