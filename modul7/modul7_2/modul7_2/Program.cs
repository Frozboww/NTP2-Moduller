using System;
using System.Collections; // ArrayList sınıfını kullanabilmek için eklenmesi zorunlu kütüphane

namespace modul7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 7: ArrayList Koleksiyon Uygulamasi ===");
            Console.WriteLine("------------------------------------------------\n");

            // YÖNERGE ADIMI: Main metodu içinde bir ArrayList koleksiyon sınıfı tanımlayınız.
            ArrayList sayi = new ArrayList();

            // YÖNERGE ADIMI: 10 elemanlı bir dizi tanımlayınız ve değerlerini atayınız.
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // YÖNERGE ADIMI: Tanımlanan dizideki elemanları koleksiyon sınıfındaki diziye ekleyiniz.
            for (int i = 0; i < 10; i++)
            {
                sayi.Add(num[i]);
            }

            // YÖNERGE ADIMI: Koleksiyon sınıfındaki 2. elemanı siliniz.
            // NOT: İndeksler 0'dan başladığı için RemoveAt(2) kodu aslında 3. sıradaki '3' rakamını siler.
            sayi.RemoveAt(2);

            // YÖNERGE ADIMI: Koleksiyon sınıfındaki 5. elemanın yerine başka bir eleman değeri atayınız.
            // NOT: Araya 2345 değerini ekler, diğer elemanları sağa doğru kaydırır.
            sayi.Insert(5, 2345);

            // YÖNERGE ADIMI: Tanımlı koleksiyon sınıfının en sonki halinde bulunan elemanların değerini ekrana yazan kodu tanımlayınız.
            Console.WriteLine("ArrayList'in Son Durumu:");

            // Başlangıçta 10 eleman vardı, 1 tane silinip 1 tane eklendiği için boyut yine tam 10 kaldı.
            // Bu yüzden döngümüz dökümandaki gibi i < 10 şeklinde güvenle çalışır.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(sayi[i]);
            }

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Program basariyla calisti. Cikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}