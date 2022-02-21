using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserValidation.Models
{
    public class Employee
    {
        [Required]
        [Display(Name ="Employee Id")]
        public int id { get; set; }
        [Display(Name ="Employee Name"),Required]
        public string Ename { get; set; }
        [Display(Name = "Email Address"), Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber), Required]
        [Display(Name = "Mobile No")]
        public string phone { get; set; }
    }
}
