using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot5
{
    interface ICalculate
    {
        double Area();
    }
    class Rectangle : ICalculate
    {
        float length;
        float width;
        public Rectangle(float x, float y)
        {
            length = x;
            width = y;
        }
        public double Area()
        {
            return length * width;
        }
    }
    class isAndAsOPerators
    {
        static void Main()
        {
            Rectangle r = new Rectangle(10.2F, 20.3F);
            ICalculate c;
            if (r is ICalculate)
            {
                c = r as ICalculate;
                Console.WriteLine("Area: {0:F2}", c.Area());

            }
            else
            {
                Console.WriteLine("Interface method not implemented");
            }
        }
    }
}
