using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {   
        [Required(ErrorMessage = "Must Provide Username")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Must be between 5 and 15 characters")]
        public string Username { get; set; }
       
        [EmailAddress(ErrorMessage = "Must have valid email address")]
        public string Email { get; set; }
        
        [Required (ErrorMessage = "Must be between 6 and 20 characters")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Password must match")]
        public string VerifyPassword { get; set; }
    }
}