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
            /* ****** Varijable ****** */
            Variables person = new Variables();//Kreiranje objekta na osnovu klase Variables

            Console.WriteLine("My name : " + person.name); //Ispis atributa string name

            Console.WriteLine("My age : " + person.age);//Ispis atributa int age

            Console.WriteLine("My grade : " + person.grade);//Ispis atributa double grade

            if (person.student) { Console.WriteLine("I'm student"); } else { Console.WriteLine("I'm not student"); } // na osnovu vrednosti
            //atributa bool student ispisati odrenjei teks

            Console.WriteLine("Firs letter of my name : " + person.myLetter);//Ispis atributa char myLetter


            /* ****** Sintaksa ****** */
            Console.WriteLine("1.Syntax \n");

            HelloWorld program = new HelloWorld();   //Kreiranje objekta na osnovu klase HelloWorld

            Console.WriteLine(program.PrvaRecenica); //Ispis atributa PrvaRecenica

            Console.Write(program.Rec + " " + program.DrugaRec); //Ispis spoja atributa Rec i Druga rec

            Console.ReadLine();
        }
    }
}
