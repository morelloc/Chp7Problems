using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5
{
    class GirlScout
        
    {
           
        private string name;
        private double number;
        private double dues;

        public const string motto = "to obey the Girl Scout law";

        public GirlScout()
        {
            name = "Name";
            number = 0;
            dues = 0;
        }
        
        public GirlScout(string empName, double empNumber, double empDues)
        {
            name = empName;
            number = empNumber;
            dues = empDues;
        }


        public string Name {get; set;}
        public double Number { get; set; }
        public double Dues { get; set; }

    }
        
        
}
