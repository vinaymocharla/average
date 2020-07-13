using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, average;
            Console.WriteLine("enter two numbers");
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            average = num1 + num2 / 2;
            Console.WriteLine($"average of 2 numbers is {average}");
            Console.ReadLine();

        }
    }
}
