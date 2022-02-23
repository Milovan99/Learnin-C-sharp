using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zirafa
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Milovan Jakovljevic";
            int god = 22;
            char grade = 'A';
            double alBlode = 1.2;
            bool isMale = true;
            Console.WriteLine("Hello " + name);
            Console.WriteLine("You have " + god + " age");

            name = "Nikola s Nikolic";

            Console.WriteLine("You could be named " + name);
            Console.WriteLine("You have " + grade + " gade from programming");
            Console.WriteLine("Have " + alBlode + " alc in you blode");

            if (isMale == true)
            {
                Console.WriteLine("You are a \n man");
            }
            else
            {
                Console.WriteLine("You are a female");
            }
            Console.WriteLine("Your name have " + name.Length + " characthters :" +name.ToUpper());


            string have;

            if (name.Contains("M"))
            {
               have = "sadrzi slovo M";
            }
            else
            {
                 have = "ne sadrzi slovo M firs letter of your name is "+name[0];
            }
            Console.WriteLine("Your name " + have );
            Console.WriteLine("Mesto razmaka " + name.IndexOf(" "));
            Console.WriteLine("Zadnja tri slova imena " + name.Substring(3,4));

            Console.ReadLine();


        }
    }
}
