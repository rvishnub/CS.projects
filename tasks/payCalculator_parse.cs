using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pay Calculator");

            float hours;
            Console.WriteLine("Enter your hours: ");
            hours = float.Parse(Console.ReadLine());

            float ratePerHour;
            Console.WriteLine("Enter your rate of pay:");
            ratePerHour = float.Parse(Console.ReadLine());

            float pay;
            pay = (hours * ratePerHour);

            Console.WriteLine("Your total pay is $" + pay);

            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}