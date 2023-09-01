using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Shape
    {
        private string? Name;

        public Shape(string? name)
        {
            Name1 = name;
        }

        //Encapsualtions
        public string? Name1 { get => Name; set => Name = value; }

        // Method

        public void GetInfo()
        {
            Console.WriteLine("Name of the shape is " + Name1);
        }
    }
}
