using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Reactangle : Shape
    {
        private double area;

        public Reactangle(string? name, double area) : base(name)
        {
            this.Area = area;
        }
        public double Area { get => area; set => area = value; }

        //Method

        public new void GetInfo()
        {
            Console.WriteLine("Name of the rectangle is " + Name1 + " and the area for the rectangle is "+Area);
        }
    }
}
