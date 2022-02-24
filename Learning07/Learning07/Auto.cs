using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning07
{
    class Auto
    {
        private string ime;
        private string boja;
        private Motor motor;
        private int gorivo;

        public void SetIme(string ime)
        {
            this.ime = ime;
        }
        public void SetBoja(string boja)
        {
            this.boja = boja;
        }

        public Auto(string ime,string boja)
        {
            this.SetIme(ime);
            this.SetBoja(boja);
            this.motor = new Motor();
            this.gorivo = 0;
        }

        public string GetIme()
        {
            return ime;
        }
        public string GetBoja()
        {
            return boja;
        }
        public int GetGorivo()
        {
            return gorivo;
        }

        public void UgasiMotor()
        {
            motor.Ugasi();
            Console.WriteLine(ime + " je ugasen");
        }

        public void UpaliMotor()
        {

            if (motor.JeUgasen()){
                if (gorivo >= 50)
                {
                    motor.Upali();
                    Console.WriteLine(ime + " je upaljen");
                    gorivo -= 50;
                }
                else
                {
                    Console.WriteLine(ime + " nema goriva , trenutno stanje :" + gorivo);
                }
            }
            else
            {
                Console.WriteLine(ime + " je vec upaljen");
            }
        
        }

        public void SipajGorivo(int gorivo)
        {
            this.gorivo = gorivo;
            Console.WriteLine("Sipali ste " + gorivo + " goriva i trenutno imate " +GetGorivo());
        }
    }
}
