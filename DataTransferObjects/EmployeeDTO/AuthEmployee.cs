using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.EmployeeDTO
{
    public class AuthEmployee
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Lozinka mora duga od 4 do 20 karaktera")]
        public string Password { get; set; }
    }
}
