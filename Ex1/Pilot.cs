using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex1
{
    internal class Pilot:Human
    {
        public Pilot(string name, int age) : base(name, age)
        {
            
        }
        public override void Work()
        {
            Console.WriteLine("Pilot flies in the sky.");
        }
    }
}
