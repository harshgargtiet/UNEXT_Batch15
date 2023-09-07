using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Rectangle: Shape
    {
        private double area;

        public Rectangle(double area)
        {
            Area = area;
        }

        public double Area { get => area; set => area = value; }

        public new void GetInfo()
        {
            Console.WriteLine("Rectangle area is " + Area);
        }
    }
}
