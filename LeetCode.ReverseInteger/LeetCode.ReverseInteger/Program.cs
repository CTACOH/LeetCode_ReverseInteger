using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer to reverse");
            int number = int.Parse(Console.ReadLine());
            int result = new ReverseInteger().Reverse(number);
            Console.WriteLine("Reverse integer: " + result);
            Console.Read();
        }
    }
}
