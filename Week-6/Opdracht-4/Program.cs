using System;
using System.Linq;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer een tekst in: ");
            string tekst = Console.ReadLine();

            int aantalPunten;
            int aantalKommas;
            int aantalPuntKommas;

            OnderzoekTekst(tekst, out aantalPunten, out aantalKommas, out aantalPuntKommas);

            Console.WriteLine("\nPunten: {0}", aantalPunten);
            Console.WriteLine("Komma's: {0}", aantalKommas);
            Console.WriteLine("puntkomma's: {0}", aantalPuntKommas);
            Console.ReadKey();
        }

        static void OnderzoekTekst(string tekst, out int aantalPunten, out int aantalKommas, out int aantalPuntKommas)
        {
            aantalPunten = tekst.Count(x => x == '.');
            aantalKommas = tekst.Count(x => x == ',');
            aantalPuntKommas = tekst.Count(x => x == ';');
        }
    }
}
