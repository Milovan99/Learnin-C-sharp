using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning05
{
    public class Motor
    {
        public enum Stanje { RADI , NE_RADI};
        private Stanje stanje = Stanje.NE_RADI;

        public void pokreni()
        {
            stanje = Stanje.RADI;
        }

        public void ugasi()
        {
            stanje = Stanje.NE_RADI;
        }

        public Stanje getStanje()
        {
            return stanje;
        }

        public Boolean radi()
        {
            return stanje == Stanje.RADI;
        }

        public Boolean neRadi()
        {
            return stanje == Stanje.NE_RADI;
        }
    }
}
