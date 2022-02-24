using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Biggest number is : " + GetMax(num1, num2, num3));
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            if( num1 > num2 && num1 > num3)
            {
                return num1;
            }else if(num2 >num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
