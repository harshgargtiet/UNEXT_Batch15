using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Bikes : IBikes
    {
        private string? name, enginetype;
        private int wheels;

        public Bikes(string? name, string? enginetype, int wheels)
        {
            this.Name = name;
            this.Enginetype = enginetype;
            this.Wheels = wheels;
        }

        public string? Name { get => name; set => name = value; }
        public string? Enginetype { get => enginetype; set => enginetype = value; }
        public int Wheels { get => wheels; set => wheels = value; }

        public void makeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
