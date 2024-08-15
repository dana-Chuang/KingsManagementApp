using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class UsersModel
    {
        public int Id { get; set; }
        [Display(Name = "Company Code")]
        public string? CompanyCode { get; set; }
        [Display(Name = "Employee Number")]
        public string? EmployeeNo { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        public int Status { get; set; }
        public string? Password { get; set; }
    }
}
