using System;

namespace modul7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 7: Uygulama Faaliyeti 1 (Foreach ile Dizi Toplami) ===");
            Console.WriteLine("---------------------------------------------------------------\n");

            // YÖNERGE ADIMI: Program gövdesi Main metodu içinde bir dizi tanımlayınız.
            int[] sayi = { 1, 2, 3, 4 };

            // YÖNERGE ADIMI & DERLEME HATSASI ÇÖZÜMÜ: 
            // Kitaptaki "int toplam;" tanımı derleme hatası vereceği için aritmetik işlem öncesinde 
            // toplama değişkenine etkisiz eleman olan 0 (sıfır) başlangıç değeri atanmıştır.
            int toplam = 0;

            // YÖNERGE ADIMI: Main metodu içinde foreach ifadesi kullanarak dizi elemanlarının toplamını tutunuz.
            foreach (int i in sayi)
            {
                toplam = toplam + i;
            }

            // YÖNERGE ADIMI: Dizi elemanlarının toplam sonucunu ekrana yazan kodu tanımlayınız.
            Console.WriteLine("Dizi Elemanlarinin Toplam Sonucu: " + toplam);

            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine("Program basariyla calisti. Cikmak icin bir tusa basin...");

            // YÖNERGE ADIMI: Programı çalıştırarak test ediniz (F5). Konsolun kapanmaması için ReadKey eklenmiştir.
            Console.ReadKey();
        }
    }
}