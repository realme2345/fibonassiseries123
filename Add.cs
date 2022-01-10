using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Add
    {
        public static void addNumbers()
        {
            Console.WriteLine("Enter a First Number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            int second = Convert.ToInt32(Console.ReadLine());
            int result = first + second;
            Console.WriteLine("addition of two numbers=" +  result);
            

        }

    }
}
