using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEShellBasicPrograms
{
    internal class Bikes : IBikes
    {
        private string? name, enginetype;
        private int wheels;

        public Bikes(string? name, string? enginetype, int wheels)
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
