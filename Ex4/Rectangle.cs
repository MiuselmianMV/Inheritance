using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex4
{
    public class Rectangle:Shape
    {
        protected int SideA;
        protected int SideB;


        public Rectangle(int size, int sideA, int sideB) : base(size)
        {
            SideA = sideA;

            SideB = sideB;

        }


        public override void Area()
        {
            base.Area();
            Console.WriteLine("Area of rectangle: {0}", SideA*SideB);
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine("Side A length = {0}cm.\nSide B length = {1}cm.", SideA, SideB);
        }
    }
}
