using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Bird : Animal
    {
        public Bird(int age, string name) : base(age, name)
        {
        }
        public new void MakeSound()
        {
            Console.WriteLine("Chirp");
        }
    }
}
