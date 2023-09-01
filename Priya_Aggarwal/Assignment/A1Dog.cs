using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class A1Dog : A1Animal
    {
        public A1Dog(string? name, int age) : base(name, age)
        {
        }

        public new void MakeSound()
        {
            Console.WriteLine(Name + " of age " + Age + " is Barking");
        }
    }
}
