using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osman_1281404.Models
{
    public class Doctor : EntityBase
    {
        
        public string DoctorName { get; set; }
        public string Degrees { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        
    }
}
