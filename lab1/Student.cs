using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Student
    {
        int Enrollment_No,Semester;
        string Student_Name;
        double SPI, CPI;

        public Student() {

            Console.WriteLine("Enter Enrollment Number:-");
            Enrollment_No=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:-");
            Student_Name=Console.ReadLine();

            Console.WriteLine("Enter Semester:-");
            Semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter SPI:-");
            SPI=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter CPI:-");
            CPI=Convert.ToDouble(Console.ReadLine());

        }


        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollment Number:-" + Enrollment_No);
            Console.WriteLine("Student Name:-" + Student_Name);
            Console.WriteLine("Semester:-" + Semester);
            Console.WriteLine("SPI:-" + SPI);
            Console.WriteLine("CPI:-" + CPI);
        }
    }
}
