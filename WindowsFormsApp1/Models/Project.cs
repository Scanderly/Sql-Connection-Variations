using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Project
    {
        public string Description { get; set; }
        public string CompletedDate { get; set; }
        public Skill[] UsedSkills { get; set; }

    }
}
