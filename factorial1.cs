using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class factorial1
    {
        public static void ReadValuesUser()
        {
            Console.Write("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            int i;
            for (i=1;i<=number;i++)
            {
                factorial = factorial*i;
            }

            Console.Write($"Factorial is: {factorial}");
            Console.ReadLine();
        }
    }
}
