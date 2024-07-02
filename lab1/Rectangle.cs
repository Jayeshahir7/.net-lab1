using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Rectangle
    {
        double length, breadth;

        public Rectangle()
        {
            Console.WriteLine("Enter Length :-");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Breadth:-");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void area()
        {
            double area = length * breadth;
            Console.WriteLine("Area of Rectangle is:- "+area);
        }
    }
}
