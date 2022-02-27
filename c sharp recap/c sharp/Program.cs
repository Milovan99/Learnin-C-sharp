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
            /* ****** Metode konverzije ****** */
            Console.WriteLine("3.Conversion methods \n");
            TypeConversionMethods conversion = new TypeConversionMethods();
            Console.WriteLine("Double value " + conversion.myDouble + " is conversed to int :" + Convert.ToInt32(conversion.myDouble));
           
            Console.WriteLine("Int value " + conversion.myInt + " is conversed to double :" + Convert.ToDouble(conversion.myInt));
            
            Console.WriteLine("Bool value " + conversion.myBool + " is conversed to string :" + Convert.ToString(conversion.myBool) +"\n");


            /* ****** Varijable ****** */
            Console.WriteLine("2.Variables \n");
            Variables person = new Variables();//Kreiranje objekta na osnovu klase Variables

            Console.WriteLine("My name : " + person.name); //Ispis atributa string name

            Console.WriteLine("My age : " + person.age);//Ispis atributa int age

            Console.WriteLine("My grade : " + person.grade);//Ispis atributa double grade

            if (person.student) { Console.WriteLine("I'm student"); } else { Console.WriteLine("I'm not student"); } // na osnovu vrednosti
            //atributa bool student ispisati odrenjei teks

            Console.WriteLine("Firs letter of my name : " + person.myLetter + "\n");//Ispis atributa char myLetter


            /* ****** Sintaksa ****** */
            Console.WriteLine("1.Syntax \n");

            HelloWorld program = new HelloWorld();   //Kreiranje objekta na osnovu klase HelloWorld

            Console.WriteLine(program.PrvaRecenica); //Ispis atributa PrvaRecenica

            Console.Write(program.Rec + " " + program.DrugaRec); //Ispis spoja atributa Rec i Druga rec

            Console.ReadLine();
        }
    }
}
