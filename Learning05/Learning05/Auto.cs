using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning05
{
    public class Auto
    {
            private string naziv;
            private string boja;
            private int gorivo;
        private Motor motor;
        public void setNaziv(String naziv)
        {
            this.naziv = naziv;
        }
        public void setBoja(String boja)
        {
            this.boja = boja;
        }

        public Auto(String naziv,String boja)
        {
            this.setNaziv(naziv);
            this.setBoja(boja);
            this.gorivo = 0;
        }

        public string getNaziv()
        {
            return naziv;
        }
        public  string getBoja()
        {
            return boja;
        }
        public int getGorivo()
        {
            return gorivo;
        }

        public void pokreniAuto()
        {
            if (gorivo >= 50)
            {
                motor.pokreni();
                Console.WriteLine(naziv + " auto je pokrenuto");
                gorivo -= 50;
            }
            else
            {
                Console.WriteLine(naziv + " auto nema goriva");
            }
        }
        public void zaustaviAuto()
        {
            motor.ugasi();
            Console.WriteLine(naziv +" auto je zaustavljeno");
        }
        public void sipajGorivo(int koliko)
        {
            gorivo += koliko;
            Console.WriteLine("Nasuto je " + koliko + "goriva i ukupno ima " + getGorivo());
        }
    }
}
