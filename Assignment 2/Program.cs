using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target number: ");
            string input = Console.ReadLine();
            int targetnumber = int.Parse(input);

            int count = 0;


            //.. Reading the first number: 
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                if (number == targetnumber)
                {
                    count++;
                }

                //.. Reading the next number:
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
            }

                


                Console.WriteLine("Count of number equal to target number: {0}", count);

                Console.ReadKey();
            

        }

    }
}
