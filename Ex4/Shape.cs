using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex4
{
    internal class Shape
    {
        protected int Size;
        public Shape(int size)
        {
            Size = size;
        }
        public virtual void Area()
        {
            Console.WriteLine("Shape's abstract area = {0}", Size);
        }

        public virtual void Show()
        {
            Console.WriteLine("Shape's abstract area = {0}", Size);
        }
    }
}
