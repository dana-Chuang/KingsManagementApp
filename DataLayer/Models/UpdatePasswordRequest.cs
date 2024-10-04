using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class UpdatePasswordRequest
    {
        public int Id { get; set; }
        public string NewPassword { get; set; }
        public string UpdatedBy { get; set; }
    }
}
