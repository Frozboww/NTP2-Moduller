using System;

namespace modul6_2
{
    class Program
    {
        // YÖNERGE ADIMI: Program sınıfında Main metodunu bulun ve bu metodun üst kısmında "Nokta" sınıfını oluşturunuz.
        // YÖNERGE ADIMI: Yazdığınız sınıfın "Program" sınıfının içinde olmasına dikkat ediniz.
        class Nokta
        {
            private int x, y;

            // Sınıftan üretilen tüm nesnelerin ORTAK kullanacağı static (paylaşılan) alan
            private static int noktaSayisi = 0;

            // Parametresiz Kurucu Metot
            public Nokta()
            {
                this.x = 0;
                this.y = 0;
                noktaSayisi++; // Her yeni nesne üretildiğinde ortak sayacı 1 artırır
            }

            // Parametreli (Aşırı Yüklenmiş) Kurucu Metot
            public Nokta(int x, int y)
            {
                this.x = x;
                this.y = y;
                noktaSayisi++; // Her yeni nesne üretildiğinde ortak sayacı 1 artırır
            }

            // YÖNERGE ADIMI: Nokta sınıfına static metodu da ekleyiniz.
            // Bu metoda nesne üzerinden değil, direkt sınıf adı üzerinden (Nokta.NoktaSayisi) ulaşılır.
            public static int NoktaSayisi()
            {
                return noktaSayisi;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 6: Uygulama Faaliyeti 2 (Static Uyeler) ===");
            Console.WriteLine("---------------------------------------------------\n");

            // YÖNERGE ADIMI: Main metodunun içerisinde üç tane nokta nesnesi oluşturunuz.
            // YÖNERGE ADIMI: Oluşturduğunuz nesnelere anlamlı isimler veriniz (nokta1, nokta2 vb.).

            Console.WriteLine("-> 1. Nokta nesnesi (Varsayilan Kurucu ile) olusturuluyor...");
            Nokta nokta1 = new Nokta();

            Console.WriteLine("-> 2. Nokta nesnesi (Parametreli Kurucu ile) olusturuluyor...");
            Nokta nokta2 = new Nokta(10, 20);

            Console.WriteLine("-> 3. Nokta nesnesi (Parametreli Kurucu ile) olusturuluyor...\n");
            Nokta nokta3 = new Nokta(45, 90);

            // YÖNERGE ADIMI: NoktaSayisi() metodunu kullanarak kaç nokta oluşturulduğunu ekrana yazdırınız.
            // YÖNERGE ADIMI: NoktaSayisi() metodunun statik olduğunu unutmayınız (Yani "nokta1.NoktaSayisi()" yazılamaz, "Nokta.NoktaSayisi()" yazılmalıdır).

            int toplamNokta = Nokta.NoktaSayisi();
            Console.WriteLine("Bellekte Olusturulan Toplam Nokta Sayisi: " + toplamNokta);

            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine("Program basariyla tamamlandi. Cikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}