using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    interface Gross1
    {
     public double Gross_Salary();
    }
   
    class Employee
    {
        public string Name;
        public double Basic_Salary;
        public void basic_sal()
        {
            Console.WriteLine("Enter Name:-");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter Basic Salary:-");
            Basic_Salary = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Salary2 : Employee,Gross1
    {
        double HRA, TA, DA;

        public Salary2()
        {
            basic_sal();
            Console.WriteLine("Enter HRA:-");
            HRA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter TA:-");
            TA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter DA:-");
            DA = Convert.ToDouble(Console.ReadLine());
        }
        public Double Gross_Salary()
        {
            return (Basic_Salary+ HRA+TA+DA);
        }
        public void Display()
        {
            Console.WriteLine("Name:-{0},Salary:-{1}",Name,Gross_Salary());
        }
    }
}
