using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.Ex3
{
    public class Tiger : Animal
    {
        public Tiger(int lenOfTail, string name, int weight, int height) 
            : base(lenOfTail, name, weight, height) 
        {
            
        }


        public override void Show()
        {
            Console.WriteLine("Tiger's show:\nName: {0}\nHeight: {1}cm\nWeight: {2}kg\nLength of tail: {3}cm.\n", Name, Height, Weight, LengthOfTail);
        }
    }
}
