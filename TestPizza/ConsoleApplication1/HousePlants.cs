using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class HousePlants
    {
        // Private fields
        private string name;
        private bool food;
        private double price;
        // Public properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public bool Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
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

