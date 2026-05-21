using System;

namespace Arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 8: Arayuzler ve Soyut Siniflar Uygulamasi ===");
            Console.WriteLine("-------------------------------------------------------\n");

            // YÖNERGE ADIMI: Ogrenci ve Ogretmen sınıflarının örneklerini oluşturup uygulamanızı test ediniz.
            Ogrenci birOgrenci = new Ogrenci();
            Ogretmen birOgretmen = new Ogretmen();

            // Arayüzden (interface) gelen metotların çağrılması
            birOgrenci.Buyu();
            birOgretmen.Buyu();

            // Soyut sınıftan (abstract class) miras alınan metotların çağrılması
            birOgrenci.Oku();
            birOgretmen.Oku();

            Console.WriteLine("\n-------------------------------------------------------");
            Console.WriteLine("Program basariyla calisti. Cikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}