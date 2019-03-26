using System.ComponentModel.DataAnnotations;

namespace Firstpage.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        
        public string Username { get; set; }   

        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage ="You Must Specify password betwween 4 and 8 character")]
        public string  Password { get; set; }
    }
}