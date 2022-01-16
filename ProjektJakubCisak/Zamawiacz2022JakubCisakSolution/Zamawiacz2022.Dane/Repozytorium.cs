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
                            Id = int.Parse(tab[0]),
                            Name = tab[1],
                            Weight = double.Parse(tab[2]),
                            Price = double.Parse(tab[3].Replace(".",",")),
                            Vege = int.Parse(tab[4])
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
            //Console.WriteLine("Liczba wczytanych rekordów: {0}", listaKanapek.Count);
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
                            Id = int.Parse(tab[0]),
                            Name = tab[1],
                            Weight = double.Parse(tab[2]),
                            Price = double.Parse(tab[3].Replace(".", ",")),
                            Sugar = int.Parse(tab[4])
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
            //Console.WriteLine("Liczba wczytanych rekordów: {0}", listaNapoji.Count);
            return listaNapoji;
        }
        public List<Dessert> PobierzDaneDeserow()
        {

            string nazwaPliku = "dessert.csv";
            List<Dessert> listaDeserow = new List<Dessert>();
            if (File.Exists(nazwaPliku) == false)
            {
                Console.WriteLine("Brak deserow w dzisiejszym menu");
                return null;
            }
            using (StreamReader srd = new StreamReader(nazwaPliku))
            {
                string linia = srd.ReadLine();
                string[] tab;
                Dessert deser;
                while ((linia = srd.ReadLine()) != null)
                {
                    tab = linia.Split(';');
                    try
                    {
                        deser = new Dessert()
                        {
                            Id = int.Parse(tab[0]),
                            Name = tab[1],
                            Weight = double.Parse(tab[2]),
                            Price = double.Parse(tab[3].Replace(".", ",")),
                            Calories = int.Parse(tab[4])
                        };

                        listaDeserow.Add(deser);
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
            //Console.WriteLine("Liczba wczytanych rekordów: {0}", listaDeserow.Count);
            return listaDeserow;
        }
        public List<Addon> PobierzDaneDodatkow()
        {

            string nazwaPliku = "addon.csv";
            List<Addon> listaDodatkow = new List<Addon>();
            if (File.Exists(nazwaPliku) == false)
            {
                Console.WriteLine("Brak dodatkow w dzisiejszym menu");
                return null;
            }
            using (StreamReader srd = new StreamReader(nazwaPliku))
            {
                string linia = srd.ReadLine();
                string[] tab;
                Addon dodatek;
                while ((linia = srd.ReadLine()) != null)
                {
                    tab = linia.Split(';');
                    try
                    {
                        dodatek = new Addon()
                        {
                            Id = int.Parse(tab[0]),
                            Name = tab[1],
                            Weight = double.Parse(tab[2]),
                            Price = double.Parse(tab[3].Replace(".", ",")),
                            Sauce = int.Parse(tab[4])
                        };

                        listaDodatkow.Add(dodatek);
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
            //Console.WriteLine("Liczba wczytanych rekordów: {0}", listaDodatkow.Count);
            return listaDodatkow;
        }
        public void WyświetlDane()
        {
            List<Sandwich> listaKanapek = PobierzDaneKanapek();
            List<Drink> listaNapoji = PobierzDaneNapoji();
            List<Dessert> listaDeserow = PobierzDaneDeserow();
            List<Addon> listaDodatkow = PobierzDaneDodatkow();
            if(listaKanapek == null)
            {
                Console.WriteLine("Brak kanapek do wyświetlenia");
            }
            else
            {
                Console.WriteLine("Lista kanapek:");
                foreach(Sandwich i in listaKanapek)
                {
                    Console.WriteLine("{0,-8} {1}, {2}PLN, {3}g{4} ",
                    i.Id,i.Name,i.Price, i.Weight, i.Vege != 0 ? ", Vege": "");
                }
            }
            if (listaNapoji == null)
            {
                Console.WriteLine("Brak napoji do wyświetlenia");
            }
            else
            {
                Console.WriteLine("Lista napoji:");
                foreach (Drink i in listaNapoji)
                {
                    Console.WriteLine("{0,-8} {1}, {2}PLN, {3}g{4} ",
                    i.Id, i.Name, i.Price, i.Weight, i.Sugar != 0 ? "" : ", SUGARFREE");
                }
            }
            if (listaDeserow == null)
            {
                Console.WriteLine("Brak deserów do wyświetlenia");
            }
            else
            {
                Console.WriteLine("Lista deserow:");
                foreach (Dessert i in listaDeserow)
                {
                    Console.WriteLine("{0,-8} {1}, {2}PLN, {3}g, Cal.{4} ",
                    i.Id, i.Name, i.Price, i.Weight, i.Calories);
                }
            }if (listaDodatkow == null)
            {
                Console.WriteLine("Brak dodatków do wyświetlenia");
            }
            else
            {
                Console.WriteLine("Lista dodatkow:");
                foreach (Addon i in listaDodatkow)
                {
                    Console.WriteLine("{0,-8} {1}, {2}PLN, {3}g{4} ",
                    i.Id, i.Name, i.Price, i.Weight, i.Sauce != 0 ? ", + Sos" : "");
                }
            }
        }

        public void ZlozZamowienie()
        {
            List<Sandwich> listaKanapek = PobierzDaneKanapek();
            List<Drink> listaNapoji = PobierzDaneNapoji();
            List<Dessert> listaDeserow = PobierzDaneDeserow();
            List<Addon> listaDodatkow = PobierzDaneDodatkow();
            int nrKanapki = 0;
            int nrNapoju = 0;
            int nrDeseru = 0;
            int nrDodatku = 0;
            double suma = 0;
            Console.WriteLine("");
            Console.WriteLine("----- Złóż zamówienie -----");
            if(listaKanapek != null)
            {
                do
                {
                    Console.WriteLine("Wybierz kanapkę:");
                    nrKanapki = int.Parse(Console.ReadLine());
                } while (nrKanapki <= 0 || nrKanapki > listaKanapek.Count);
            }
            else Console.WriteLine("W dniu dzisiejszym nie przyjmujemy zamównień na kanapki");
            if (listaNapoji != null)
            {
                do
                {
                    Console.WriteLine("Wybierz Napój:");
                    nrNapoju = int.Parse(Console.ReadLine());
                } while (nrNapoju <= 0 || nrNapoju > listaNapoji.Count);
            }
            else Console.WriteLine("W dniu dzisiejszym nie przyjmujemy zamównień na napoje");
            if (listaDeserow != null)
            {
                do
                {
                    Console.WriteLine("Wybierz deser:");
                    nrDeseru = int.Parse(Console.ReadLine());
                } while (nrDeseru <= 0 || nrDeseru > listaDeserow.Count);
            }
            else Console.WriteLine("W dniu dzisiejszym nie przyjmujemy zamównień na desery");
            if (listaDodatkow != null)
            {
                do
                {
                    Console.WriteLine("Wybierz dodatek:");
                    nrDodatku = int.Parse(Console.ReadLine());
                } while (nrDodatku <= 0 || nrDodatku > listaDodatkow.Count);
            }
            else Console.WriteLine("W dniu dzisiejszym nie przyjmujemy zamównień na dodatki");


            Console.WriteLine("Podsumowanie zamówienia:");
            Console.WriteLine("");
            if(listaKanapek != null)
            {
                foreach (Sandwich i in listaKanapek)
                {
                    if (nrKanapki == i.Id)
                    {
                        suma += i.Price;
                        Console.WriteLine("Kanapka: {0}, {1}PLN, {2}g{3} ",
                   i.Name, i.Price, i.Weight, i.Vege != 0 ? ", Vege" : "");
                    }
                }
            }
            else Console.WriteLine("Kanapka: NIE WYBRANO KANAPKI");
            if (listaNapoji != null) 
            {
                foreach (Drink i in listaNapoji)
                {
                    if (nrNapoju == i.Id)
                    {
                        suma += i.Price;
                        Console.WriteLine("Napój: {0}, {1}PLN, {2}g{3} ",
                    i.Name, i.Price, i.Weight, i.Sugar != 0 ? "" : ", SUGARFREE");
                    }
                }
            }
            else Console.WriteLine("Napój: NIE WYBRANO NAPOJU");
            if (listaDeserow != null)
            {
                foreach (Dessert i in listaDeserow)
                {
                    if (nrDeseru == i.Id)
                    {
                        suma += i.Price;
                        Console.WriteLine("Deser: {0}, {1}PLN, {2}g{3} ",
                    i.Name, i.Price, i.Weight, i.Calories);
                    }
                }
            }
            else Console.WriteLine("Deser: NIE WYBRANO DESERU");
            if (listaDodatkow != null)
            {
                foreach (Addon i in listaDodatkow)
                {
                    if (nrDodatku == i.Id)
                    {
                        suma += i.Price;
                        Console.WriteLine("Dodatek: {0}, {1}PLN, {2}g{3} ",
                    i.Name, i.Price, i.Weight, i.Sauce != 0 ? ", + Sos" : "");
                    }
                }
            }
                
            Console.WriteLine("Podsumowanie:");
            Console.WriteLine("Do zapłaty: razem: {0}zł",suma);

        }
    }
}
