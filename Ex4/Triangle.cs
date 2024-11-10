using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex4
{
    public class Triangle : Shape
    {
        protected int Basement;
        protected int Perpendicular;


        public Triangle(int size, int basement, int perpendicular) : base(size)
        {
            Basement = basement;
            Perpendicular = perpendicular;
        }


        public override void Area()
        {
            base.Area();
            Console.WriteLine("Area of triangle: {0}", 0.5*Basement*Perpendicular);
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine("Basement length = {0}cm.\nPerpendicular length = {1}cm.", Basement, Perpendicular);
        }
    }
}
