using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.Models;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MaxLength(25)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string Verify { get; set; }

        public void Add()
        {
            User user = new User { Email = this.Email, Password = this.Password, Username = this.Username };
            UserData.AddUser(user);
        }

        public AddUserViewModel()
        {

        }
    }
}
