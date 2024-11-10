using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex3
{
    internal class Crocodile:Animal
    {
        public Crocodile(int lenOfTail, string name, int weight, int height) : base(lenOfTail, name, weight, height)
        {
        }
        public override void Show()
        {
            Console.WriteLine("Crocodile's show:\nName: {0}\nHeight: {1}cm\nWeight: {2}kg\nLength of tail: {3}cm.\n", Name, Height, Weight, LengthOfTail);
        }
    }
}
