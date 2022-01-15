using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamawiacz2022.Dane
{
    public class Repozytorium
    {
        public List<Sandwich> PobierzDaneKanapek()
        {
            string nazwaPliku = "sandwich.csv";
            List <Sandwich> listaKanapek = new List<Sandwich>();
            if (File.Exists(nazwaPliku) == false)
            {
                Console.WriteLine("Brak kanapek w dzisiejszym menu");
                return null;
            }
            using (StreamReader srd = new StreamReader(nazwaPliku))
            {
                string linia = srd.ReadLine();
                string[] tab;
                Sandwich sandwich;
                while((linia = srd.ReadLine()) != null)
                {
                    tab = linia.Split(';');
                    try
                    {
                        sandwich = new Sandwich()
                        {
                            Id = int.Parse(tab[1]),
                            Name = tab[2],
                            Weight = double.Parse(tab[3]),
                            Price = double.Parse(tab[4]),
                            Vege = int.Parse(tab[5])
                        };

                        listaKanapek.Add(sandwich);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                        foreach (var item in tab)
                        {
                            Console.Write("{0}, ", item);
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                }
            }
            Console.WriteLine("Liczba wczytanych rekordów: {0}", listaKanapek.Count);
            return listaKanapek;
        }
        public List<Drink> PobierzDaneNapoji()
        {
            string nazwaPliku = "drink.csv";
            List<Drink> listaNapoji = new List<Drink>();
            if (File.Exists(nazwaPliku) == false)
            {
                Console.WriteLine("Brak napoji w dzisiejszym menu");
                return null;
            }
            using (StreamReader srd = new StreamReader(nazwaPliku))
            {
                string linia = srd.ReadLine();
                string[] tab;
                Drink drink;
                while ((linia = srd.ReadLine()) != null)
                {
                    tab = linia.Split(';');
                    try
                    {
                        drink = new Drink()
                        {
                            Id = int.Parse(tab[1]),
                            Name = tab[2],
                            Weight = double.Parse(tab[3]),
                            Price = double.Parse(tab[4]),
                            Sugar = int.Parse(tab[5])
                        };

                        listaNapoji.Add(drink);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        foreach (var item in tab)
                        {
                            Console.Write("{0}, ", item);
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                }
            }
            Console.WriteLine("Liczba wczytanych rekordów: {0}", listaNapoji.Count);
            return listaNapoji;
        }
    }
}
