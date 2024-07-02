using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab1
{
    internal class Account_Details
    {
       public  double Principle, Rate, Time;

        public void GetData()
        {
            Console.WriteLine("Enter Principle Amount:-");
            Principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate:-");
            Rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter TIme Priod:-");
            Time = Convert.ToDouble(Console.ReadLine());
        }
    }


    class Interest : Account_Details
    {
        double Result;
        public void Display()
        {
            Result = (Principle * Rate * Time) / 100;
            Console.WriteLine("Interest is:-"+Result);
        }
    }
}
