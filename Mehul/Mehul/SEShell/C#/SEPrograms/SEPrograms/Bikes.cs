using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPrograms
{
    internal class Bikes: Ibikes
    {
        private string? name, enginetype;
        private int wheels;

        public Bikes(String? name, string? enginetype, int wheels)
        {
            Name = name;
            Enginetype = enginetype;
            Wheels = wheels;
        }

        public string? Name { get => name; set => name = value; }
        public string? Enginetype { get => enginetype; set => enginetype = value; }
        public int Wheels { get => wheels; set => wheels = value; }

        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
