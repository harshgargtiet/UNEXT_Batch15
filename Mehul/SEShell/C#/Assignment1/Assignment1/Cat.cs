using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Cat: Animal
    {
        public Cat(string? name, int age) : base(name, age)
        {

        }
        public new void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
