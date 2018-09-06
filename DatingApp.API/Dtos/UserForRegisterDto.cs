using System.ComponentModel.DataAnnotations;
//This file created in Section3 Lecture30
namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]//Section3 Lecture31
        public string Username {get;set;}
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 nd 8 characters")]
        public string Password {get; set;}
    }
}