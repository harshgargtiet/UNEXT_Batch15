using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Circle : Shape
    {
        private int radius;
        public Circle(string name, int radius) : base(name)
        {
            this.Radius = radius;
        }

        public int Radius { get => radius; set => radius = value; }

        public new void GetInfo()
        {
            Console.WriteLine("Radius of the circle" + Name + " is " + Radius);
        }
    }
}
