using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Distance
    {
        double dist1, dist2, dist3;

        public Distance()
        {
            Console.WriteLine("Enter Distance 1 :-");
            dist1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Distance 2 :-");
            dist2=Convert.ToDouble(Console.ReadLine());

            dist3 = 0;
        }

        public void Addition()
        {
            dist3=dist1 + dist2;
        }

        public void Display()
        {
            Console.WriteLine("Addition Distances:-"+dist3);
        }
    }
}
