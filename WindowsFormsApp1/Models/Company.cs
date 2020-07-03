using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class Company:Entity
    {
        public Vacancy[] DeclaredVacancies { get; set; }
        public CV[] CVs { get; set; }
         public Company()
        {
            DeclaredVacancies = new Vacancy[2];
        }
    }
}
