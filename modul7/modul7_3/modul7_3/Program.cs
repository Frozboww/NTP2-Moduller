using System;

namespace modul7_3
{
    class Program
    {
        // YÖNERGE ADIMI: Bir statik int params dizi parametresi alan ve int değer döndüren "toplam" isminde metot tanımlayınız.
        public static int toplam(params int[] paramList)
        {
            // YÖNERGE ADIMI: Metot içerisinde int türünde 2 değişken tanımlayıp, dizinin ilk değerlerini atayınız.
            int c = paramList[0]; // En küçük sayıyı tutacak değişken (Min)
            int d = paramList[0]; // En büyük sayıyı tutacak değişken (Max)

            // YÖNERGE ADIMI: Metot içerisinde params dizisi içerisindeki en küçük (ve en büyük) sayıyı bulan kodu tanımlayınız.
            foreach (int i in paramList)
            {
                // Eleman c'den küçükse, yeni en küçük eleman o olur
                if (i < c)
                {
                    c = i;
                }

                // Eleman d'den büyükse, yeni en büyük eleman o olur
                if (i > d)
                {
                    d = i;
                }
            }

            // YÖNERGE ADIMI: Metotta son olarak c ve d değişkenlerini toplayarak geri gönderiniz.
            return c + d;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 7: 'params' Anahtar Sozcugu Uygulamasi ===");
            Console.WriteLine("----------------------------------------------------\n");

            // YÖNERGE ADIMI: Program gövdesi Main metodu içine toplam metodunu çağırarak değerleri gönderiniz.
            // params sayesinde istediğimiz kadar sayıyı virgülle ayırarak gönderebiliyoruz.
            int toplamen = Program.toplam(9, 4, 5, 6, 19);

            Console.WriteLine("Gönderilen Sayilar: 9, 4, 5, 6, 19");

            // Program 4 (en küçük) ile 19'u (en büyük) bulup toplayacak ve ekrana 23 yazdıracaktır.
            Console.Write("En Kucuk ve En Buyuk Sayinin Toplami: ");
            Console.WriteLine(toplamen);

            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Program basariyla calisti. Cikmak icin bir tusa basin...");

            // YÖNERGE ADIMI: Console.Read(); ifadelerini kullanınız.
            Console.Read();
        }
    }
}