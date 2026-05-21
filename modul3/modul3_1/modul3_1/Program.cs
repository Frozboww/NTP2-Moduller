using System;

namespace modul3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Başlık ve konsol düzeni
            Console.WriteLine("=== Modul 3: Uygulama Faaliyeti 1 ===");
            Console.WriteLine("-------------------------------------");

            // 1. ADIM: Kullanıcıdan mantıksal sınama için iki adet sayısal değer alıyoruz
            Console.Write("Lutfen 1. Sayiyi (A) Giriniz: ");
            int sayiA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen 2. Sayiyi (B) Giriniz: ");
            int sayiB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- Iliskisel Operatorler Sınaması ---");

            // 2. ADIM: İlişkisel operatörlerin sonuçlarını boolean değişkenlere aktarma ve kontrol
            bool esitMi = (sayiA == sayiB);
            bool buyukMu = (sayiA > sayiB);
            bool kucukEsitMi = (sayiA <= sayiB);

            Console.WriteLine("A esit mi B'ye? (A == B)     : " + esitMi);
            Console.WriteLine("A buyuk mu B'den? (A > B)    : " + buyukMu);
            Console.WriteLine("A kucuk esit mi B'ye? (A <= B): " + kucukEsitMi);


            Console.WriteLine("\n--- Mantıksal Operatorler Sınaması ---");

            // 3. ADIM: VE (&&) ile VEYA (||) operatörlerini dökümandaki adımlara göre test etme
            // Örnek koşul: A sayısı 10'dan büyük VE B sayısı 50'den küçük mü?
            bool veSonucu = (sayiA > 10 && sayiB < 50);

            // Örnek koşul: A sayısı 0'a eşit VEYA B sayısı 0'a eşit mi?
            bool veyaSonucu = (sayiA == 0 || sayiB == 0);

            // DEĞİL (!) operatörü ile bir sonucun tersini alma
            bool degilSonucu = !esitMi;

            Console.WriteLine("Koşul (A > 10 VE B < 50)     : " + veSonucu);
            Console.WriteLine("Koşul (A == 0 VEYA B == 0)   : " + veyaSonucu);
            Console.WriteLine("Esit Degil Sınaması (!sonuc) : " + degilSonucu);


            Console.WriteLine("\n-------------------------------------");
            // 4. ADIM: Konsol ekranının kapanmasını engelleme
            Console.WriteLine("Program bitti. Cikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}