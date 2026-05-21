using System;

namespace modul4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 4: 2. Faaliyet - Kutulama ve Is/As Islecleri ===");
            Console.WriteLine("---------------------------------------------------------");

            // =========================================================================
            // 1. BÖLÜM: KUTULAMA (BOXING) VE KUTUYU AÇMA (UNBOXING) İŞLEMLERİ
            // =========================================================================
            Console.WriteLine("[ 1. ADIM: Boxing & Unboxing Denemesi ]");

            // int ve object türünden değişkenler oluşturup int türündeki değişkene değer atıyoruz
            int sayi = 124;
            object kutu;

            // Değerlerin kutulanması (Boxing): Değer türünün (int), başvuru türüne (object) aktarılması
            kutu = sayi;
            Console.WriteLine("Kutulama (Boxing) Yapildi -> int veri nesneye sarildi. Kutu icerigi: " + kutu);

            // Kutulamayı kaldırma (Unboxing): Başvuru türündeki verinin açıkça (cast) değer türüne geri çevrilmesi
            int kutudanCikanSayi = (int)kutu;
            Console.WriteLine("Kutu Acildi (Unboxing)     -> Nesne tekrar int turune donusturuldu: " + kutudanCikanSayi);

            Console.WriteLine("\n---------------------------------------------------------");

            // =========================================================================
            // 2. BÖLÜM: "IS" VE "AS" İŞLEÇLERİ İLE TÜR TESPİTİ VE DÖNÜŞÜMÜ
            // =========================================================================
            Console.WriteLine("[ 2. ADIM: 'is' ve 'as' Islecleri Ile Tur Kontrolu ]");

            // Değişik türden değişkenler tanımlıyoruz
            object veri1 = "Igdir Teknik Bilimler";
            object veri2 = 2026;

            // A) "is" İşleci Sınaması: Bir nesnenin belirli bir türde olup olmadığını bool (true/false) döndürerek kontrol eder.
            Console.WriteLine("\n--> 'is' Isleci Kontrolleri:");

            if (veri1 is string)
            {
                Console.WriteLine("Onay: veri1 degiskeninin turu gerçekten bir STRING'dir.");
            }

            if (veri2 is int)
            {
                Console.WriteLine("Onay: veri2 degiskeninin turu gerçekten bir INTEGER'dir.");
            }

            // B) "as" İşleci Sınaması: Tür dönüşümü yapmayı dener. Dönüştürebilirse veriyi aktarır, dönüştüremezse hata fırlatmaz, 'null' döndürür.
            Console.WriteLine("\n--> 'as' Isleci Kontrolleri:");

            // Güvenli dönüşüm denemesi (veri1 string olduğu için başarıyla dönüşecektir)
            string metinSonucu = veri1 as string;
            if (metinSonucu != null)
            {
                Console.WriteLine("Basarili Donusum: veri1 basariyla string'e cevrildi -> " + metinSonucu);
            }

            // Hatalı dönüşüm denemesi (veri2 bir sayıdır, string'e dönüştürülemez ve 'null' döner)
            string hataliDonusum = veri2 as string;
            if (hataliDonusum == null)
            {
                Console.WriteLine("Guvenli Engelleme: veri2 bir sayi oldugu icin string'e cevrilemedi ve 'null' dondu (Program cokmedi).");
            }

            Console.WriteLine("---------------------------------------------------------");
            // Konsolun hemen kapanmasını engelliyoruz
            Console.WriteLine("\nProgram bitti. Cikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}