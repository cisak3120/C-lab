using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CisakJakubSol
{
    class Nagrywarka
    {
        public enum miejsceNagrywania
        {
            DVD,
            HDD
        }
        public enum stan
        {
            WLACZONA,
            ZATRZYMANA,
            NAGRYWANIE,
            ODTWARZANIE
        }

        public stan _Stan; 
         
        public stan Stan
        {
            get 
            {
                return _Stan; 
            }
            set { }
        }

        private miejsceNagrywania _MiejsceNagrywania;

        public miejsceNagrywania MiejsceNagrywania

        {
            get { return _MiejsceNagrywania; }
            set { _MiejsceNagrywania = value; }
        } 

        public void Wlacz()
        {
            _Stan = stan.WLACZONA;
            Console.WriteLine("Włączono odtwarzanie.");
        }

        public void Wylacz()
        {

        }

        public void Odtwarzaj()
        {

        }

        public void Nagrywaj()
        {

        }
        
        public void Zatrzymaj()
        {

        }
    }
}
