using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Candidate
    {
        int Id, Age;
        string Name;
        double Height, Width;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Id:-");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:-");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Age:-");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height:-");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Width:-");
            Width = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("ID:-"+this.Id);
            Console.WriteLine("Name:-"+this.Name);
            Console.WriteLine("Age:-" + this.Age);
            Console.WriteLine("Height:-" + this.Height);
            Console.WriteLine("Width:-" + this.Width);

        }
    }
}
