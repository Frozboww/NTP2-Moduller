using System;

namespace modul6_1
{
    class Program
    {
        // YÖNERGE ADIMI: Program sınıfında Main metodunu bulun ve bu metodun üst kısmında "Bisiklet" sınıfını oluşturunuz.
        // YÖNERGE ADIMI: Yazdığınız sınıfın "Program" sınıfının içinde olmasına dikkat ediniz.
        class Bisiklet
        {
            // YÖNERGE ADIMI: Gereken anahtar sözcük ile vites ve hiz alanlarının erişilebilirliklerini değiştiriniz.
            // Sınıf dışından doğrudan erişim sağlanabilmesi için alanları "public" olarak tanımlıyoruz.
            public int hiz = 0;
            public int vites = 1;

            // YÖNERGE ADIMI: VitesSayisi adında yeni bir alan ekleyiniz ve bu alana bir ilk değer atayınız.
            public int vitesSayisi = 6;

            // YÖNERGE ADIMI: Bisiklet sınıfına varsayılan kurucu yazınız.
            public Bisiklet()
            {
                // Varsayılan kurucu çalıştığında vites başlangıç değerini 2 yapıyoruz.
                vites = 2;
            }

            // YÖNERGE ADIMI: Tamsayı türünde bir parametre alan ve bu parametre değerini VitesSayisi alanına atayan bir kurucu daha yazın.
            // (Aşırı Yüklenmiş Kurucu)
            public Bisiklet(int deger)
            {
                vites = 2;
                vitesSayisi = deger; // Dışarıdan gelen parametreyi vites sayısı alanına atar.
            }

            public void VitesDegistir(int yeniDeger)
            {
                vites = yeniDeger;
            }

            public void Hizlan(int artis)
            {
                hiz = hiz + artis;
            }

            public void FrenYap(int azalma)
            {
                hiz = hiz - azalma;
            }

            // YÖNERGE ADIMI: Bilgileri Yaz metodunu kullanarak ekrana yazılan değerleri inceleyiniz.
            public void BilgileriYaz()
            {
                Console.WriteLine("Vites Durumu: {0} | Hız: {1} | Toplam Vites Sayısı: {2}", vites, hiz, vitesSayisi);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 6: Uygulama Faaliyeti 1 (Siniflar ve Kurucular) ===");
            Console.WriteLine("------------------------------------------------------------\n");

            // YÖNERGE ADIMI: Main metodunun içerisinde iki tane bisiklet nesnesi oluşturunuz.
            // YÖNERGE ADIMI: Oluşturduğunuz nesnelere anlamlı isimler veriniz (bisiklet1, bisiklet2 vb.).

            // bisiklet1 varsayılan parametresiz kurucuyu tetikler (6 vitesli olur).
            Bisiklet bisiklet1 = new Bisiklet();

            // bisiklet2 parametreli aşırı yüklenmiş kurucuyu tetikler (21 vitesli olur).
            Bisiklet bisiklet2 = new Bisiklet(21);

            // YÖNERGE ADIMI: Oluşturduğunuz nesnelerin VitesDegistir, Hizlan, Frenyap metotlarını farklı kereler kullanınız.
            // YÖNERGE ADIMI: İki nesne için kullandığınız metotlarda farklı değerler kullanınız.
            Console.WriteLine("-> Metotlar farklı değerlerle çalıştırılıyor...");

            bisiklet1.Hizlan(15);
            bisiklet1.VitesDegistir(3);

            bisiklet2.Hizlan(40);
            bisiklet2.VitesDegistir(5);
            bisiklet2.FrenYap(15);

            Console.WriteLine("\n--- Metot Kullanımı Sonrası Ekran Çıktıları ---");
            Console.Write("bisiklet1 -> ");
            bisiklet1.BilgileriYaz();

            Console.Write("bisiklet2 -> ");
            bisiklet2.BilgileriYaz();

            Console.WriteLine("\n------------------------------------------------------------");

            // YÖNERGE ADIMI: Bu alanların değerlerini metot kullanmadan doğrudan değiştiriniz.
            // Alanlar public yapıldığı için metot çağırmadan direkt atama yapabiliyoruz.
            Console.WriteLine("-> Değerler metot kullanılmadan doğrudan değiştiriliyor...");

            bisiklet1.hiz = 60;   // Doğrudan hızı 60 yaptık
            bisiklet1.vites = 6;  // Doğrudan vitesi 6 yaptık

            Console.WriteLine("\nbisiklet1 Yeni Durum (Doğrudan Atama Sonrası):");
            Console.Write("bisiklet1 -> ");
            bisiklet1.BilgileriYaz();

            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine("Program başarıyla tamamlandı. Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}