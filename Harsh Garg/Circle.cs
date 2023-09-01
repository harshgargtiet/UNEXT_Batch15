using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Circle : Shape
    {
        private int radius;

        public Circle(string? name,int radius) : base(name)
        {
            this.Radius = radius;
        }

        public int Radius { get => radius; set => radius = value; }

        public new void GetInfo()
        {
            Console.WriteLine("The name of this circle is "+Name1+", the radius of this circle is "+Radius);
        }
    }
}
