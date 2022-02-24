using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning07
{
    class Motor
    {
        public enum Stanje { RADI , NE_RADI};
        public Stanje stanje = Stanje.NE_RADI;

        public void Upali()
        {
            stanje = Stanje.RADI;
        }

        public void Ugasi() {
            stanje = Stanje.NE_RADI;
        }

        public Stanje GetStanje()
        {
            return stanje;
        }

        public bool JeUpaljen()
        {
            return stanje == Stanje.RADI;
        }

        public bool JeUgasen()
        {
            return stanje == Stanje.NE_RADI;
        }
    }


}
