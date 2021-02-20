using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
       static bool is_leap(int myYear)
        {

            return true;
        }

        static void Main(string[] args)
        {
            int my_Year;
            Console.Write("Enter a number please: ");
            my_Year = Convert.ToInt32(Console.ReadLine());
            if (is_leap(my_Year))
            {
                Console.WriteLine($" {my_Year} is a leap year.");
            }
            else
            {
                Console.WriteLine($" {my_Year} is not a leap year.");
            }
            Console.ReadKey();
        }
    }
}
