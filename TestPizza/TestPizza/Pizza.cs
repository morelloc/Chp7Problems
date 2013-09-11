using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    class Pizza
    {
        // Private fields
        private string toppings;
        private int diameter;
        private double price;
        // Public properties
        public string Toppings
        {
            get 
            {
                return toppings;
            }
            set
            {
                toppings = value;
            }
        }
        
        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}

