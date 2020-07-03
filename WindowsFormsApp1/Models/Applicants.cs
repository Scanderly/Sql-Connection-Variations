using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Applicants:Entity
    {
        public string Surname { get; set; }
        public string Password { get; set; }
        public CV Cv { get; set; }
        public string PassportNumber { get; set; }
    }
}
