using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Animal
    {
        private int age;
        private string name;

        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public void MakeSound()
        {
            Console.WriteLine("BOOO");
        }
    }
}
