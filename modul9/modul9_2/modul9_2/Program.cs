using System;
using System.Collections.Generic;
using System.Threading;

namespace modul9_2
{
    // =========================================================================
    // SENARYO 1: ALIVERİŞ SEPETİ OLAY YAPISI (Urun ve Sepet Sınıfları)
    // =========================================================================

    // Ürün bilgilerini tutan sınıf
    class Urun
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public Urun(string urunAdi, double fiyat)
        {
            UrunAdi = urunAdi;
            Fiyat = fiyat;
        }
    }

    // Ürün eklendiğinde tetiklenecek olay için temsilci (Delegate)
    delegate void SepetEtkinligiHandler();

    // Ürün listesinin tutulduğu ve olayın tanımlandığı Sepet sınıfı
    class Sepet
    {
        // Ürün listesini tutan koleksiyon
        private List<Urun> urunListesi = new List<Urun>();

        // YÖNERGE ADIMI: Ürün eklendiğinde tetiklenecek bir olay tanımlayınız.
        public event SepetEtkinligiHandler UrunEklendi;

        public void UrunEkle(Urun yeniUrun)
        {
            urunListesi.Add(yeniUrun);
            Console.WriteLine($"-> {yeniUrun.UrunAdi} ({yeniUrun.Fiyat} TL) sepete eklendi.");

            // Olayı tetikliyoruz (Yayıncı/Publisher)
            if (UrunEklendi != null)
            {
                UrunEklendi();
            }
        }

        // Sepetteki tüm ürünlerin toplam tutarını hesaplayan metot
        public double ToplamTutariHesapla()
        {
            double toplam = 0;
            foreach (var urun in urunListesi)
            {
                toplam += urun.Fiyat;
            }
            return toplam;
        }
    }

    // =========================================================================
    // SENARYO 2: MAKİNE SICAKLIK KONTROL OLAY YAPISI (Makine Sınıfı)
    // =========================================================================

    // Sıcaklık limiti aşıldığında tetiklenecek olay için temsilci
    delegate void MakineEtkinligiHandler(int mevcutSicaklik);

    class Makine
    {
        private int sicaklik;
        public bool CalisiyorMu { get; private set; } = true;

        // YÖNERGE ADIMI: Sıcaklık özelliği 1000 derecenin üstüne çıktığında çağrılacak olay.
        public event MakineEtkinligiHandler YuksekSicaklikUyarisi;

        // Sıcaklık özelliğinin kapsüllenmiş hali (Property)
        public int Sicaklik
        {
            get { return sicaklik; }
            set
            {
                sicaklik = value;
                Console.WriteLine($"Makine Anlik Sicakligi: {sicaklik}°C");

                // YÖNERGE ADIMI: Sıcaklık değeri 1000 derecenin üstüne çıktığında olay çağrılacaktır.
                if (sicaklik > 1000 && CalisiyorMu)
                {
                    if (YuksekSicaklikUyarisi != null)
                    {
                        YuksekSicaklikUyarisi(sicaklik); // Olayı fırlatıyoruz
                    }
                }
            }
        }

        // YÖNERGE ADIMI: Olay yakalandığında çalıştırılacak kapat fonksiyonu
        public void Kapat()
        {
            CalisiyorMu = false;
            Console.WriteLine("[SISTEM] ACIL DURUM: Makine guvenli bir sekilde KAPATILDI!");
        }
    }

    // =========================================================================
    // ANA PROGRAM SINIFI (Olay Dinlemelerinin Yapıldığı Yer)
    // =========================================================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Modul 9: Olaylar (Events) Uygulamasi ===");
            Console.WriteLine("--------------------------------------------\n");

            // -----------------------------------------------------------------
            // BÖLÜM 1: ALIŞVERİŞ SEPETİ SİMÜLASYONU
            // -----------------------------------------------------------------
            Console.WriteLine("--- 1. BOLUM: ALISVERIS SEPETI UYGULAMASI ---");
            Sepet sepetim = new Sepet();

            // YÖNERGE ADIMI: Konsolda yer alan program sınıfınızda olay dinlemesini yapınız (Abone Olma / Subscribe)
            // Sepete ürün eklendiğinde çalışacak olay metodunu bağlıyoruz
            sepetim.UrunEklendi += Sepetim_UrunEklendi;

            // YÖNERGE ADIMI: Ürün bilgileri klavyeden girilecektir.
            for (int i = 1; i <= 2; i++)
            {
                Console.Write($"\n{i}. Urunun Adini Giriniz: ");
                string ad = Console.ReadLine();

                Console.Write($"{i}. Urunun Fiyatini Giriniz: ");
                double fiyat = Convert.ToDouble(Console.ReadLine());

                Urun kullaniciUrunu = new Urun(ad, fiyat);
                sepetim.UrunEkle(kullaniciUrunu); // Bu metot olayı tetikler
            }

            // Olay metodunun gövdesi (Main içinde yerel fonksiyon olarak veya dışarıda tanımlanabilir)
            // YÖNERGE ADIMI: Her olay gerçekleştiğinde toplam tutar ekrana mesaj olarak yazdırılacaktır.
            void Sepetim_UrunEklendi()
            {
                double guncelToplam = sepetim.ToplamTutariHesapla();
                Console.WriteLine($"[OLAY BILGISI] Sepet Guncel Toplam Tutari: {guncelToplam} TL");
            }

            Console.WriteLine("\n--------------------------------------------\n");

            // -----------------------------------------------------------------
            // BÖLÜM 2: MAKİNE SICAKLIK SİMÜLASYONU
            // -----------------------------------------------------------------
            Console.WriteLine("--- 2. BOLUM: MAKINE SICAKLIK KONTROLU ---");
            Makine endustriyelMakine = new Makine();

            // YÖNERGE ADIMI: Program tarafından dinlenen olay yakalandığında makinenin kapat fonksiyonu çalıştırılacaktır.
            endustriyelMakine.YuksekSicaklikUyarisi += (mevcutSicaklik) =>
            {
                Console.WriteLine($"\n[OLAY BILGISI] KRITIK SICAKLIK ASILDI! Okunan Deger: {mevcutSicaklik}°C");
                endustriyelMakine.Kapat(); // Kapat fonksiyonunu tetikliyoruz
            };

            // YÖNERGE ADIMI: Sıcaklık değeri program içinde rastgele (random) üretilecektir.
            Random rastgele = new Random();
            Console.WriteLine("-> Makine calistirildi, rastgele sicaklik degerleri uretiliyor...");

            while (endustriyelMakine.CalisiyorMu)
            {
                // 800 ile 1100 derece arasında rastgele sıcaklık üretiyoruz
                int yeniSicaklik = rastgele.Next(800, 1100);
                endustriyelMakine.Sicaklik = yeniSicaklik;

                // Ekranda adımları rahat izleyebilmek için yarım saniye bekletiyoruz
                Thread.Sleep(500);
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("Program basariyla tamamlandi. Cikmak icin bir tusa basin...");
            Console.ReadKey();
        }
    }
}