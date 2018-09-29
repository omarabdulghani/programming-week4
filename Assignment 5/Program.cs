using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            Console.Write("Enter a year: ");
              int year = int.Parse(Console.ReadLine());

            while (year != 0) 
            {
                //..if year is leap

                if  (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                    Console.WriteLine("{0} is a leap year", year);


                    Console.Write("Enter a year: ");
                    year = int.Parse(Console.ReadLine());
                }
                else if (year < 0)
                {
                    Console.WriteLine("Enter a positive number!");


                    Console.Write("Enter a year: ");
                    year = int.Parse(Console.ReadLine());

                }
                else

                { 
                    Console.WriteLine("{0} is not a leap year", year);

                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());

                }

            }
           

            

        }
    }
}
