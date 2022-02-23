using System;
using DependencyInjection.Class;

namespace DependencyInjection
{
    class Program
    {  
        static void Main(string[] args)
        {
            // Telefon için
            TeknikServis teknikServis_telefon = new TeknikServis(new Telefon());
            teknikServis_telefon.CihazYenileme();
            teknikServis_telefon.Onarim();

            // Bilgisayar için
            TeknikServis teknikServis_Bilgisayar = new TeknikServis(new Bilgisayar());
            teknikServis_Bilgisayar.CihazYenileme();
            teknikServis_Bilgisayar.Onarim();

            // Televizyon için
            TeknikServis teknikServis_Televizyon = new TeknikServis(new Televizyon());
            teknikServis_Televizyon.CihazYenileme();
            teknikServis_Televizyon.Onarim();

            Console.ReadLine();
        }
    }
}
