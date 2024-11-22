using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osman_1281404.Models
{
    public enum Gender { Male,Female}
    public class Patient : EntityBase
    {
        public string Disease {  get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
