using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Shape
    {
        private string? name;

        public Shape(string? name)
        {
            Name = name;
        }

        public void GetInfo() 
        {
           Console.WriteLine("Hello");
        }

        public string? Name { get => name; set => name = value; }
    }
}
