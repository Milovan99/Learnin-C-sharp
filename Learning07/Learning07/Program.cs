using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning07
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto audi = new Auto("Mercedes", "Crna");
            
            audi.SipajGorivo(80);
            audi.UpaliMotor();
            audi.UpaliMotor();
            audi.UgasiMotor();
            audi.UpaliMotor();
            Console.ReadLine();
        }
    }
}
