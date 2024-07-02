using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Salary
    {
        public double Basic, TA, DA, HRA, GrossSalary;
        public Salary()
        {
            DA = 0.1;
            HRA = 0.2;
            Console.WriteLine("Enter Basic Salary:-");
            Basic=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter TA:");
            TA = Convert.ToDouble(Console.ReadLine());

            GrossSalary = Basic + TA + DA + HRA;
        }

        public void Display()
        {
            Console.WriteLine("Basic salary:-"+Basic);
            Console.WriteLine("Dearness allowence:-" +DA);
            Console.WriteLine("Housing rent allowence:-" + HRA);
            Console.WriteLine("Travelling allowence:-" + TA);
            Console.WriteLine("Gross Salary:-" + GrossSalary);
        }
    }
}
