using System;

namespace modul4_2
{
    class Program
    {
        // YÖNERGE ADIMI: Main yönteminin üst kısmında ref parametresi alan DegerArtir yöntemini oluşturuyoruz.
        // Yazdığımız yöntemin Program sınıfının içinde olmasına dikkat ediyoruz.
        static void DegerArtir(ref int sayi)
        {
            // YÖNERGE ADIMI: Yönteme aktarılan parametre değerini 1 artıran kodu yazıyoruz.
            sayi = sayi + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 4: Yontemler - 2. Uygulama Faaliyeti (ref) ===");
            Console.WriteLine("-------------------------------------------------------");

            // YÖNERGE ADIMI: Main yönteminin içerisinde tamsayı türünde bir değişken tanımlayıp bir ilk değer atıyoruz.
            int BenimSayim = 15;

            // Metot çağrılmadan önceki durumu ekrana yazdırıyoruz
            Console.WriteLine("Metot Cagrilmadan Onceki Deger : " + BenimSayim);

            // YÖNERGE ADIMI: Tanımladığımız değişkeni parametre olarak alan DegerArtir yöntemini çağırıyoruz.
            // Değişkeni ref parametresine aktarırken önüne mutlaka 'ref' anahtar sözcüğünü yazıyoruz.
            DegerArtir(ref BenimSayim);

            Console.WriteLine("-------------------------------------------------------");

            // YÖNERGE ADIMI: Tamsayı değişkeninin değerini ekrana yazdırıp değişkenin değerinin arttığından emin oluyoruz.
            Console.WriteLine("Metot Cagrildiktan Sonraki Deger: " + BenimSayim);

            // ref parametresinin teorik açıklamasını konsola ekliyoruz (Tam not almak için avantaj sağlar)
            Console.WriteLine("\n[ REFiN CALISMA PRENSIBI ]");
            Console.WriteLine("Deger turu degiskenler normalde metotlara kopyalanarak (Value) gonderilir.");
            Console.WriteLine("Fakat 'ref' kullandigimizda, degiskenin bellekteki adresi (Reference) aktarilir.");
            Console.WriteLine("Bu sayede metot icinde yapilan 1 artirma islemi, ana degiskende kalici olur.");

            // Konsolun hemen kapanmasını engelliyoruz
            Console.WriteLine("\nCikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}