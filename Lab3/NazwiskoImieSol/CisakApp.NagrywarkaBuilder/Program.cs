using CisakJakubSol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CisakApp.NagrywarkaBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Nagrywarka nagrywarka = new Nagrywarka();
            nagrywarka.Wlacz();
            nagrywarka.Odtwarzaj();
            Console.WriteLine("Stan nagrywarki " + nagrywarka.Stan);
            //Console.WriteLine(nagrywarka.Stan);
            nagrywarka.Nagrywaj();
            nagrywarka.Zatrzymaj();
            nagrywarka.Nagrywaj();
            Console.WriteLine("Stan nagrywarki " + nagrywarka.Stan);
            nagrywarka.Odtwarzaj();
            nagrywarka.Zatrzymaj();


            Console.ReadLine();

        }
    }
}
