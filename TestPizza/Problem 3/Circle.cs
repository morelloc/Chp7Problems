using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    class Circle
    {
        // Private fields
        private double radius;
        private double diameter;
        private double area;
        // Public properties
        readonly double Diameter;
        readonly double Area;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                diameter = value * 2;
                area = (value * value) * Math.PI;
            }
        }
    }
}
