using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double counter = 0;
            double sum = 0;

            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            while (number != 0)     //.. when 0 is entered = calculate average
            {
                if (number > 0)
               {
                    counter++;
                    sum = sum + number;
                }

                Console.Write("Enter a number: ");
                number = double.Parse(Console.ReadLine());

               
                
            }


            /// ...
            double average = 0;
            if (counter > 0)
            {
                 average = sum / counter;
            }
            

            Console.Write("Average of all positive numbers is: {0:0.00}", average);

            
                Console.ReadKey();


        }
    }
}
