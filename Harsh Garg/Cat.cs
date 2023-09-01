using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Cat : Animal
    {
        public Cat(string? name, int? age) : base(name, age)
        {
        }

        public new void MakeSound()
        {
            Console.WriteLine("Meow Meow Meow!");
        }
    }
}
