using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex3
{
    internal class Animal
    {
        public string Name;
        public int Weight;
        public int Height;
        public int LengthOfTail;
        public Animal(int lenOfTail, string name, int weight, int height)
        {
            Name = name;
            Weight = weight;
            Height = height;
            LengthOfTail = lenOfTail;
        }

        public virtual void Show()
        {
            Console.WriteLine("Base animal show:\nName: {0}\nHeight: {1}cm\nWeight: {2}kg\nLength of tail: {3}cm.\n", Name, Height, Weight, LengthOfTail);
        }
    }
}
