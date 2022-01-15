using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamawiacz2022.Dane;

namespace Zamawiacz2022.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zamawiacz2022";
            Console.WriteLine("Zamawiacz 2022 - wersja konsolowa");
            Console.WriteLine("");

            Repozytorium repozytorium = new Repozytorium();
            //repozytorium.PobierzDaneKanapek();
            repozytorium.PobierzDaneNapoji();
            Console.ReadKey();
        }
    }
}
