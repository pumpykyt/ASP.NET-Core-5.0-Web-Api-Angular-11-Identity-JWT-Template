using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.DTO.Models
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Please, enter email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, enter password")]
        public string Password { get; set; }
    }
}
