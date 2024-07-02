using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Furniture
    {
        public  string Material;
        public  double price;
    }

    class Table:Furniture
    {
        double Height, surface_area;

        public void GetData()
        {
            Console.WriteLine("Enter Material:-");
            Material = Console.ReadLine();
            Console.WriteLine("Enter Price:-");
            price=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height:-");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Surface_area");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Material:-"+Material);
            Console.WriteLine("Price:-" +price);
            Console.WriteLine("Height:-" + Height);
            Console.WriteLine("Surface-area:-"+surface_area);
        }
    }

}
