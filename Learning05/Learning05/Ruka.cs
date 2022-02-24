using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning05
{
    class Ruka
    {
        public enum Stanje { SAVIJENA , ISPRUZENA};
        private Stanje stanje = Stanje.ISPRUZENA;

        public void savij()
        {
            stanje = Stanje.SAVIJENA;
        }
        public void ispruzi()
        {
            stanje = Stanje.ISPRUZENA;
        }

        public Stanje getStanje()
        {
            return stanje;
        }

        public bool jeSavijena()
        {
            return stanje == Stanje.SAVIJENA;
        }

        public bool jeIspruzenja()
        {
            return stanje == Stanje.ISPRUZENA;
        }
    }
}
