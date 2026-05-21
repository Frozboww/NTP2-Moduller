using System;

namespace modul2_2
{
    // 1. Adım: Tarih adında bir yapı (struct) tanımlıyoruz
    struct Tarih
    {
        public int gun;
        public int ay;
        public int yildan; // Dökümandaki isimlendirmeye sadık kalındı

        // 2. Adım: Başlangıç değerlerini aktarmak için bir kurucu (constructor) oluşturuyoruz
        public Tarih(int m_gun, int m_ay, int m_yildan)
        {
            gun = m_gun;
            ay = m_ay;
            yildan = m_yildan;
        }

        // Bilgileri ekrana yazdırmak için yardımcı metot
        public void TarihGoster()
        {
            Console.WriteLine("Atanan Tarih: {0}/{1}/{2}", gun, ay, yildan);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yeni Yapi (Struct) Uygulamasi");
            Console.WriteLine("-----------------------------");

            // 3. Adım: Oluşturduğumuz kurucuyu kullanarak başlangıç değerlerini aktarıyoruz
            Tarih bugununTarihi = new Tarih(17, 5, 2026);

            // Değerleri konsol ekranına yazdırıp test ediyoruz
            bugununTarihi.TarihGoster();

            Console.ReadKey();
        }
    }
}