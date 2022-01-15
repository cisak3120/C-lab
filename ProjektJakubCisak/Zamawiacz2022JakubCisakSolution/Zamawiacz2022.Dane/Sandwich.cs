using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamawiacz2022.Dane
{
    public class Sandwich : Produkt
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override double Price { get; set; }

        public int Vege { get; set; }
    }
}
