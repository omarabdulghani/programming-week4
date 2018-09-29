using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0;
            int secondnumber = 1;
            int sum = 0;
            int num = 0;

            while (sum >= num && sum < 4181)
            {
                sum = firstnumber + secondnumber;

                
                Console.Write(sum + ", "); 

                firstnumber = secondnumber;
                secondnumber = sum;
            }
            Console.Write("6765");


            Console.ReadKey();
        }
    }
}
