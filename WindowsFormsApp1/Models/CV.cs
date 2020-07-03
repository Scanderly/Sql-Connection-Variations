using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class CV
    {
        public Applicants Applicants { get; set; } 
        public Skill[] Skills { get; set; }
        public string[] Hobbies { get; set; }
        public Project[] Projects { get; set; }
        public byte Experience { get; set; }
    }
}
