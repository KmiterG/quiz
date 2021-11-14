using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Gra gra = new Gra();
            gra.BiezacaKategoria = 500;
            PokazPowitanie();
            Pytanie pierwszePytanie = gra.WylosujPytanie();
            string oU = PokazPytanie(pierwszePytanie);
            int odpLiczba = int.Parse(oU);

            if (oU == "1")
            {
                PoprawnaOdpowiedz(pierwszePytanie);
            }
            else
            {
                KoniecGry();
            }

            Console.ReadLine();
        }

        static void PokazPowitanie()
        {
            Console.WriteLine("Witaj w Quizie. Jest 5 pytań !!!");
            Console.WriteLine("Kliknij Enter");
            Console.ReadLine();
        }

        static string PokazPytanie(Pytanie pytanie)
        {
            Console.Clear();
            //Console.WriteLine("Pytanie za " + pytanie.Kategoria + " pkt.");
            Console.WriteLine($"Pytanie za {pytanie.Kategoria} pkt.");
            Console.WriteLine();
            Console.WriteLine(pytanie.Tresc);
            Console.WriteLine();

            foreach (Odpowiedz odp in pytanie.Odpowiedzi)
            {
                //kod zostatnie wykonany tyle razy ile elementów ma kolekcja
                Console.WriteLine($"{odp.Id}. {odp.Tresc}");
            }

            Console.WriteLine();
            Console.Write("Prosze wybrać numer odpowiedzi: ");
            return Console.ReadLine();
        }

        static void PoprawnaOdpowiedz(Pytanie pytanie)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Brawo, to prawidłowa odpowiedz. Wygrywasz {pytanie.Kategoria} pkt.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void KoniecGry()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
//Powitanie
//Stworzenie pytań i odpowiedzi
//Losowanie pytania
//Wyświetlenie uzytkownikowi
//Czekamy na odpowiedź
//Ewaluacja opowiedzi
//Dobra (podwyższamy kategorie i wracamy do wybrania pytania)
//Zła (koniec gry)
