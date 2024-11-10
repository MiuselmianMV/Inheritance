using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex4
{
    internal class Square:Shape
    {
        protected int Side;
        public Square(int size, int side):base(size)
        {
            Side = side;
        }
        public override void Area()
        {
            base.Area();
            Console.WriteLine("Area of Square: {0}", Side*Side);
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Side length = {0}cm.", Side);
        }
    }
}
