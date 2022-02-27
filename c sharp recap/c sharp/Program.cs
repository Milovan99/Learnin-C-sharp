using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ****** Sintaksa ****** */
            HelloWorld program = new HelloWorld();   //Kreiranje objekta na osnovu klase HelloWorld
            Console.WriteLine(program.PrvaRecenica); //Ispis atributa PrvaRecenica
            Console.Write(program.Rec + " " + program.DrugaRec); //Ispis spoja atributa Rec i Druga rec
            Console.ReadLine();
        }
    }
}
