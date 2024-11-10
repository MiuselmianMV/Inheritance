using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex1
{
    internal class Sailor : Human
    {
        public Sailor(string name, int age) : base(name, age)
        {
            
        }
        
        public override void Work()
        {
            Console.WriteLine("Sailor sails far in the sea.");
        }

    }
}
