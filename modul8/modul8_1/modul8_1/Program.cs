using System;

namespace modul8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 8: Kalitım ve Cok Bicimlilik Uygulamasi ===");
            Console.WriteLine("----------------------------------------------------\n");

            // YÖNERGE ADIMI: Ogrenci sınıfının bir örneğini oluşturup ad, boy ve kilo alanlarını ekrana yazdırınız.
            Ogrenci birOgrenci = new Ogrenci("Ali UZUN");

            Console.WriteLine("Adı:");
            Console.WriteLine("{0}", birOgrenci.Ad);
            Console.WriteLine("Boyu:");
            Console.WriteLine("{0}", birOgrenci.Boy);
            Console.WriteLine("Kilosu:");
            Console.WriteLine("{0}", birOgrenci.Kilo);

            Console.WriteLine("\n----------------------------------------------------");

            // YÖNERGE ADIMI: Main metodu içinden Daire sınıfının bir örneğini oluşturup alanını ekrana yazdırınız.
            Daire daire = new Daire(3.0);
            Console.WriteLine("Dairenin Alanı:");
            Console.WriteLine("{0}", daire.Alan());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\nProgram basariyla tamamlandi. Cikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}