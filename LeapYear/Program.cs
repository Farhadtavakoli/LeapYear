using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* if year is not divisible by 4 then it is a common year
else if year is not divisible by 100 then it is a leap year
else if year is not divisible by 400 then it is a common year
else it is a leap year 
*/



namespace LeapYear
{
    class Program
    {
       
        static bool is_leap(int myYear)
        {
            if (myYear % 4 != 0 && myYear % 400 != 0)
                return false;
            else if (myYear % 100 != 0 )
                return true;
            else
                return true;
        }


        static void Main(string[] args)
        {
            int my_Year = 1;
            while (my_Year != 0)
            {
                Console.Write("Enter a year please: ");
                my_Year = Convert.ToInt32(Console.ReadLine());
                if( my_Year == 0)
                    break;
                if (is_leap(my_Year))
                {
                    Console.WriteLine($" {my_Year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($" {my_Year} is a common year");
                }
            } 
            Console.ReadKey();
        }
    }
}
