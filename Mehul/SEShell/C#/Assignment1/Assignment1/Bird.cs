using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Bird :Animal
    {
        public Bird(string? name, int age) : base(name, age)
        {

        }
        public new void MakeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
