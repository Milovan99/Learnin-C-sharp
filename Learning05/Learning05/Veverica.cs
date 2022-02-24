using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning05
{
    class Veverica
    {
        private string ime;
        private string boja;
        private Ruka levaRuka;
        private Ruka desnaRuka;
        private string staDrzi;

        public void setIme(String ime)
        {
            this.ime = ime;
        }

        public void setBoja(String boja)
        {
            this.boja = boja;
        }

        public Veverica(string ime, string boja)
        {
            this.setIme(ime);
            this.setBoja(boja);
            this.levaRuka = new Ruka();
            this.desnaRuka = new Ruka();
            this.staDrzi = "Nista";
        }

        public string getIme()
        {
            return ime;
        }

        public string getBoja()
        {
            return boja;
        }
        public string getStaDrzi()
        {
            return staDrzi;
        }

        public void savijLevuRuku()
        {
            levaRuka.savij();
            Console.WriteLine(ime + " je savila levu ruku");
        }
        public void savijDesnuRuku()
        {
            desnaRuka.savij();
            Console.WriteLine(ime + " je savila desnu ruku");
        }

        private void proveriDaLiMozeDaDrzi(Ruka ruka)
        {
            if (ruka.jeIspruzenja())
            {
                Console.WriteLine(ime + " je ispustila " + staDrzi);
                staDrzi = "Nista";
            }
        }

        public void ispruziLevuRuku()
        {
            levaRuka.ispruzi();
            Console.WriteLine(ime + " je ispruzila levu ruku");
            proveriDaLiMozeDaDrzi(desnaRuka);
            
        }
        public void ispruziDesnuRuku()
        {
            desnaRuka.ispruzi();
            Console.WriteLine(ime + " je ispruzila desnu ruku");
            proveriDaLiMozeDaDrzi(levaRuka);
        }


        public void pridrzi(string sta)
        {
            if (levaRuka.jeSavijena() || desnaRuka.jeSavijena())
            {
                staDrzi = sta;
                Console.WriteLine(ime + " pridrzava " +sta);
            }
            else
            {
                Console.WriteLine(ime + " ne moze da pridzi  " + sta);
            }

        }
    }
}
