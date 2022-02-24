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
            Veverica v1 = new Veverica("Chip", "Braon");

            v1.savijLevuRuku();
            v1.pridrzi("Lesnik");
            v1.ispruziLevuRuku();
            Console.WriteLine(v1.getStaDrzi());

            Console.ReadLine();
        }

    }
}
