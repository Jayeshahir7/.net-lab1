using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Staff
    {
        string Name, Department, Designation; 
        double Experience,Salary;
        Staff[] staff = new Staff[2];

        public void GetData()
        {
            for (int i = 0; i < staff.Length; i++)
            {
                staff[i] = new Staff();

                Console.WriteLine("Enter Name:-");
                staff[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Department:-");
                staff[i].Department = Console.ReadLine();

                Console.WriteLine("Enter Designation:-");
                staff[i].Designation = Console.ReadLine();

                Console.WriteLine("Enter Experience:-");
                staff[i].Experience =Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Salary:-");
                staff[i].Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }

        }

        public void Display()
        {
            Console.WriteLine("---HOD---");
            for (int i = 0; i < staff.Length; i++)
            {
                if (staff[i].Designation=="HOD")
                {
                    Console.WriteLine("Name :-" + staff[i].Name);
                    Console.WriteLine("Salary :-" + staff[i].Salary);
                }
            }
        }


    }
}
