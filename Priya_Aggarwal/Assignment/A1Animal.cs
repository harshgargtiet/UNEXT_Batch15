using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class A1Animal
    {
        private string? name;
        private int age;

        public A1Animal(string? name, int age)
        {
            Name = name;
            Age = age;
        }

        public string? Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void MakeSound()
        {
            Console.WriteLine("Animal making sound");
        }
    }
}
