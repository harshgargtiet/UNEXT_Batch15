using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Dog : Animal
    {
        public Dog(string? name, int? age) : base(name, age)
        {
        }
        public new void MakeSound()
        {
            Console.WriteLine("Woof Woof Woof!");
        }
    }
}
