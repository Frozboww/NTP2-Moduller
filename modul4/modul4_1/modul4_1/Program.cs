using System;

namespace modul4_1
{
    class Program
    {
        // YÖNERGE ADIMI: Program sınıfının içinde Bisiklet sınıfını oluşturuyoruz
        class Bisiklet
        {
            int hiz = 0;
            int vites = 0;

            // Yapıcı metot (Constructor)
            public Bisiklet()
            {
                vites = 18;
            }

            public void Hizlan(int artis)
            {
                hiz = hiz + artis;
            }

            public void BilgileriYaz()
            {
                Console.Write("Vites:{0} ", vites);
                Console.WriteLine("Hiz: {0}", hiz);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 4: Uygulama Faaliyeti 1 ===");
            Console.WriteLine("-------------------------------------");

            // YÖNERGE ADIMI: Main metodu içinde bisiklet1 nesnesini new ile oluşturuyoruz
            Bisiklet bisiklet1 = new Bisiklet();

            // YÖNERGE ADIMI: İkinci nesneyi tanımlayıp ilk değer olarak bisiklet1'i atıyoruz (new kullanmadan)
            Bisiklet bisiklet2 = bisiklet1;

            // YÖNERGE ADIMI: Sadece ilk bisiklet nesnesinin Hizlan yöntemini çağırıyoruz
            Console.WriteLine("-> bisiklet1 nesnesi 25 birim hizlandiriliyor...");
            bisiklet1.Hizlan(25);

            Console.WriteLine("\n--- Nesnelerin Durumu ---");

            // YÖNERGE ADIMI: Her iki nesnenin de BilgileriYaz yöntemlerini çağırıyoruz
            Console.Write("bisiklet1 Bilgileri: ");
            bisiklet1.BilgileriYaz();

            Console.Write("bisiklet2 Bilgileri: ");
            bisiklet2.BilgileriYaz();

            Console.WriteLine("-------------------------------------");

            // YÖNERGE ADIMI: Bilgilerin neden aynı çıktığının analizi ve tartışma açıklaması
            Console.WriteLine("\n[ TARTISMA VE ANALIZ ]");
            Console.WriteLine("Soru: bisiklet2'yi hizlandirmadigimiz halde bilgileri neden degisti?");
            Console.WriteLine("Cevap: Cunku siniflar (class) BASVURU (REFERANS) turundedir.");
            Console.WriteLine("'bisiklet2 = bisiklet1;' satiri yazildiginda bellekten yeni bir yer acilmaz.");
            Console.WriteLine("Her iki nesne de bellekteki (Heap) AYNI adrese basvuru yapmaya baslar.");
            Console.WriteLine("Bu yuzden birinde yapilan degisiklik digerini de doğrudan etkiler.");

            // Konsolun hemen kapanmasını engelliyoruz
            Console.WriteLine("\nCikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}