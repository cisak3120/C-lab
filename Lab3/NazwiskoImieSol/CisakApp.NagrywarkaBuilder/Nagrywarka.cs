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
            Console.WriteLine("Włączono nagrywarkę.");
        }

        public void Wylacz()
        {
            Console.WriteLine("Wyłączono nagrywarkę");
        }

        public void Odtwarzaj()
        {
            if (Stan == stan.NAGRYWANIE)
                Console.WriteLine("Nie można odtwarzać bo trwa aktualnie nagrywanie!"); 
            else
            {
                _Stan = stan.ODTWARZANIE;
                Console.WriteLine("Włączono odtwarzanie."); 
            }
        }

        public void Nagrywaj()
        {
            if (Stan == stan.ODTWARZANIE)
                Console.WriteLine("Nie mozna nagrywać bo trwa aktualnie odtwarzanie!"); 
            else
            {
                _Stan = stan.NAGRYWANIE;
                Console.WriteLine("Włączono nagrywanie."); 
            }
        }

        public void Zatrzymaj()
        {
            if(Stan == stan.ODTWARZANIE)
            {
                _Stan = stan.ZATRZYMANA;
                Console.WriteLine("Zatrzymano odtwarzanie.");
            } else if (Stan == stan.NAGRYWANIE)
            {
                _Stan = stan.ZATRZYMANA;
                Console.WriteLine("Zatrzymano nagrywanie");
               
            }
            
        }
    }
}
