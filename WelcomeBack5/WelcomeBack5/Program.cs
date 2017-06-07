using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a program that reads a valid month number and prints the number of days in the month.
namespace WelcomeBack5
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter month number
            Console.WriteLine("Please enter a month number.");
            string input = Console.ReadLine();
            int month;
            //convert to integer
            int.TryParse(input, out month);
            if (month < 1 || month > 12)//if number less than 1 or greater than 12
            {
                Console.WriteLine("Not a valid month number!");//output not a valid number
            }
            else if (month == 9 || month == 4 || month == 6 || month == 11)//if number eqauls 9,4  or 6
            {
                Console.WriteLine("30 Days.");//output 30 days
            }
            //if number equals 1,3,5,7,8,10 or 12
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("31 Days.");//output 31 days
            }
            else
                //else output 29 days
                Console.WriteLine("29 Days.");
        }
    }
}
