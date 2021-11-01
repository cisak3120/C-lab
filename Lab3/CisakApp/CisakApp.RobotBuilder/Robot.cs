using CisakApp.RobotBuilder.Urządzenia.Wejścia;
using CisakApp.RobotBuilder.Urządzenia.Wyjścia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CisakApp.RobotBuilder
{
    class Robot
    {
        private string kodSerii;
        private int nrSerii;
        private bool wlaczony;
        private Kamera kamera;
        private Mikrofon mikrofon;
        private Głośnik głośnik;
        private Lampa lampa; 



        public Robot(string kod, int nr)
        {
            kodSerii = kod;
            nrSerii = nr;
            wlaczony = false;
            kamera = new Kamera();
            mikrofon = new Mikrofon();
            głośnik = new Głośnik();
            lampa = new Lampa();
        }

        public string Seria
        {
            get { return kodSerii + "-" + nrSerii; }
            set { }
        }
        public void Uruchom()
        {
            if( wlaczony == false) {
                wlaczony = true;
            }
        }

        public void DajSygnal()
        {
            if(wlaczony == true )
            Console.WriteLine("Sygnał: Wrrrp bleep");
            
        }
    }
}
