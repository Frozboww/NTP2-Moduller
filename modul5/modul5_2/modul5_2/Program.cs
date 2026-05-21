using System;

namespace modul5_2
{
    class Program
    {
        // =========================================================================
        // AŞIRI YÜKLENMİŞ (OVERLOAD) KAREAL METOTLARI
        // =========================================================================

        // 1. Metot: Bir int parametre alan ve int değer döndüren "kareal" metodu
        static int kareal(int x)
        {
            // Metodun aldığı x parametresini kendisiyle çarparak geri gönderiyoruz
            return x * x;
        }

        // 2. Metot: Bir double parametre alan ve double değer döndüren "kareal" metodu
        static double kareal(double x)
        {
            // Metodun aldığı x parametresini kendisiyle çarparak geri gönderiyoruz
            return x * x;
        }

        // 3. Metot: Bir string parametre alan ve int değer döndüren "kareal" metodu
        static int kareal(string x)
        {
            // HATA DÜZELTMESİ: Dökümandaki "int32" ifadesi, C# standartlarına uygun olarak Int32 (veya int) şeklinde düzeltildi.
            // Metodun aldığı x parametresini int türüne çevirip kendisiyle çarparak geri gönderiyoruz.
            return Int32.Parse(x) * Int32.Parse(x);
        }

        // =========================================================================
        // PROGRAMIN ANA GÖVDESİ (MAIN METODU)
        // =========================================================================
        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 5: Faaliyet 2 - Metotlari Asiri Yukleme ===");
            Console.WriteLine("-----------------------------------------------------");

            // YÖNERGE ADIMI: Program gövdesi Main metodunun içine istenen kodları yazıyoruz.
            // Derleyici, parantez içine yazdığımız veri türüne bakarak yukarıdaki 3 metottan hangisini çağıracağını kendisi seçer.

            Console.WriteLine(kareal(5));     // int alan 1. metodu tetikler. Çıktı: 25
            Console.WriteLine(kareal(5.1));   // double alan 2. metodu tetikler. Çıktı: 26,01
            Console.WriteLine(kareal("3"));   // string alan 3. metodu tetikler. Çıktı: 9

            Console.Read(); // Programın hemen kapanmasını önleyen dökümandaki son adım

            // NOT: Dökümanda istenen Step Into (F11) adımlarını uygulayarak, sarı okun 
            // sırasıyla veri türüne göre doğru metoda nasıl zıpladığını debug ekranında izleyebilirsin.
        }
    }
}