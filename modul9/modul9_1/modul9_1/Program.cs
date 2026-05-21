using System;

namespace modul9_1
{
    class Program
    {
        // YÖNERGE ADIMI: Bir temsilci (delegate) türü tanımlayınız. 
        // Öneri uyarınca void dönüş tipine sahip ve "ref string[]" parametresi alan bir temsilci oluşturduk.
        public delegate void DiziTemsilcisi(ref string[] dizi);

        // =========================================================================
        // TEMSİLCİNİN ÇAĞIRACAĞI 3 FARKLI METOT
        // =========================================================================

        // 1. Metot: Sözcük (string) dizisini A'dan Z'ye sıralayan metot
        public static void SiralaAZ(ref string[] dizi)
        {
            Array.Sort(dizi);
            Console.WriteLine("[Mesaj] Dizi A'dan Z'ye basariyla siralandi.");
        }

        // 2. Metot: Sözcük (string) dizisini Z'den A'ya sıralayan metot
        public static void SiralaZA(ref string[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            Console.WriteLine("[Mesaj] Dizi Z'den A'ya basariyla siralandi.");
        }

        // 3. Metot: İzlemeyi kolaylaştırmak için dizinin o anki halini ekrana yazdıran metot
        public static void DiziYazdir(ref string[] dizi)
        {
            Console.Write("Dizi Elemanlari: ");
            foreach (string eleman in dizi)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine("\n");
        }

        // =========================================================================
        // ANA GÖVDE (MAIN)
        // =========================================================================
        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 9: Temsilciler (Delegates) Uygulamasi ===");
            Console.WriteLine("---------------------------------------------------\n");

            // Test için üzerinde çalışacağımız isim dizisi
            string[] isimler = { "Yusuf", "Ahmet", "Can", "Buse", "Elif" };

            // YÖNERGE ADIMI: Sıralanmamış diziyi ekrana yazdırınız.
            Console.WriteLine("--- ILK DURUM ---");
            DiziYazdir(ref isimler);

            // YÖNERGE ADIMI: Temsilcinin bir örneğini oluşturunuz. (Tekli Çağrım Testi)
            Console.WriteLine("--- TEKLI CAGRIM TESTI (A-Z) ---");
            DiziTemsilcisi temsilci = new DiziTemsilcisi(SiralaAZ);

            // Metot çağrımı temsilci üzerinden gerçekleştirilecektir.
            temsilci(ref isimler);
            DiziYazdir(ref isimler);

            // YÖNERGE ADIMI: Çoklu çağrımlarda bulununuz (Multicast Delegate Zinciri).
            // Temsilci nesnemize += operatörü ile diğer metotları sıra ile bağlıyoruz.
            Console.WriteLine("--- COKLU CAGRIM ZINCIRI TESTI (+=) ---");

            temsilci = SiralaZA;       // Önce Z-A sıralama metodunu ata
            temsilci += DiziYazdir;    // Ardından ekrana yazdırma metodunu zincire ekle

            // Temsilci tek bir kez çağrıldığında, zincire bağlı olan metotlar sıra ile tetiklenir.
            Console.WriteLine("-> Temsilci zinciri tek seferde tetikleniyor...");
            temsilci(ref isimler);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Program basariyla tamamlandi. Cikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}