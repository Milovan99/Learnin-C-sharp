using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto audi = new Auto("Audi", "Crni");

            audi.sipajGorivo(100);
            audi.pokreniAuto();
            audi.zaustaviAuto();
        }

    }
}
