using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex4
{
    public class Circle : Shape
    {
        protected int Radius;
        public Circle(int size, int radius):base(size)
        {
            Radius = radius;
        }


        public override void Area()
        {
            base.Area();
            Console.WriteLine("Area of Circle: {0}", Radius*Radius*Math.PI);
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine("Radius length = {0}cm.", Radius);
        }
    }
}
