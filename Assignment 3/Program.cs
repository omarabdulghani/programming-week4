using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int sum = 0;

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                counter++;

                if (number > 0 && counter % 5 == 0) 
                {
                    
                    

                    sum = sum + number;
                }

                


                Console.Write("Enter a number: ");

                number = int.Parse(Console.ReadLine());

            }



            Console.WriteLine("Sum of the 5th, 10th, 15th ... number is = {0}", sum);


            Console.ReadKey();

        }
    }
}

