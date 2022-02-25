using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning08
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "pogodi";
            string guess = "";
            int num = 5;
            Console.WriteLine("Broj pokusaka " +num+". Pokusaj pogoditi rec:");
            guess = Console.ReadLine();
            while (guess != word && num > 1)
            {
               
                Console.WriteLine("Broj pokusaja "+(num-1)+". Pokusaj ponovo pogoditi rec:");
                guess = Console.ReadLine();
                num--;
            }
            if (guess == word)
            {
                Console.WriteLine("Pogodak iz " + num + ". pokusaja");
            }
            else
            {
                Console.WriteLine("Niste uspeli ,pokusajte ponovo");
            }
            Console.ReadLine();
        }
    }
}
