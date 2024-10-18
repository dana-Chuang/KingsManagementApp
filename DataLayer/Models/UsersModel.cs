using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class UsersModel: BaseModel
    {
        [Display(Name = "Company Code")]
        public string? CompanyCode { get; set; }
        [Display(Name = "Employee Number")]
        public string? EmployeeNo { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Status")]
        public int Status { get; set; }
        [Display(Name = "Email")]
        public string? Email { get; set; }
        [Display(Name = "Is Admin")]
        public int IsAdmin { get; set; }
        [Display(Name = "Password")]
        public string? Password { get; set; }
    }
}
