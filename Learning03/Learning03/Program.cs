using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Enter your numbers :");
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] luckyNumbers = new int[nums];
            for ( int i = 0;i < nums; i++) {
                Console.WriteLine("Enter " + (i+1)  + ". number:");
                luckyNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your numbers are :");
            for (int k = 0; k < nums; k++)
            {
                Console.Write(" " + luckyNumbers[k]);
            }
            Console.ReadLine();
        }
    }
}
