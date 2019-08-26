using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        protected double Salary { get; set; }


        public string GetFullName()
        {
            return Name + " " + Surname;
        }

    }
}
