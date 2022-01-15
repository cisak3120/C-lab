using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamawiacz2022.Dane
{
    public class Dessert : Produkt
    {
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Calories { get; set; }
    }
}
