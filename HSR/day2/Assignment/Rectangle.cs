using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Rectangle : Shape
    {
        private double area;

        public Rectangle(string name, double area) : base(name)
        {
            this.Area = area;
        }

        public double Area { get => area; set => area = value; }

        public new void GetInfo()
        {
            Console.WriteLine("Area of the rectangle " + Name + " is " +  Area);
        }
    }
}
