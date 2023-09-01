using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Animal
    {
        private string? name;
        private int? age;

        public Animal(string? name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string? Name { get => name; set => name = value; }
        public int? Age { get => age; set => age = value; }

        //Method

        public void MakeSound()
        {
            Console.WriteLine("Animal Sounds in Backgrounds");
        }
    }
}
