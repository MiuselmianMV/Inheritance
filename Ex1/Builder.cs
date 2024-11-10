using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex1
{
    public class Builder : Human
    {
        public Builder(string name, int age):base(name, age)
        {
         
        }


        public override void Work()
        {
            Console.WriteLine("Builer builds a house.");
        }
    }
}
