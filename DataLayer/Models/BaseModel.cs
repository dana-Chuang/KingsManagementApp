using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class BaseModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Created By")]
        public String? CreatedBy { get; set; }
        [Display(Name = "Updated On")]
        public DateTime UpdatedOn { get; set; }
        [Display(Name = "Updated By")]
        public String? UpdatedBy { get; set; }
    }
}
