using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamawiacz2022.Dane
{
    public abstract class Produkt
    {
        //klasa abstrakcyjna dla podoruktów 
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract double Weight { get; set; }
        public abstract double Price { get; set; }

         
    }
}
