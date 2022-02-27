using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operation (+,-,/,*) : ");
            string operation =Console.ReadLine();
            
            Console.Write("Enter second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch
(operation)
            {
                case "+":
                     Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("You enter invalid sing");
                    break;
            };

            Console.ReadLine();

        }
    }
}
