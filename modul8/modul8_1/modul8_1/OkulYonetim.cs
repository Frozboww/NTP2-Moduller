using System;

namespace modul8_1
{
    // YÖNERGE ADIMI: OkulYonetim sınıfının adını Insan olarak değiştiriniz.
    class Insan
    {
        // YÖNERGE ADIMI: Insan sınıfına boy, kilo ve ad alanları ile kurucu metot ve Buyu metodunu ekleyiniz.
        public double Boy, Kilo;
        public string Ad;

        public Insan(string ad)
        {
            this.Ad = ad;
            this.Boy = 0.45;
            this.Kilo = 3.5;
        }

        public void Buyu()
        {
            Boy += 0.5;
            Kilo += 0.5;
        }
    }

    // YÖNERGE ADIMI: OkulYonetim.cs dosyasına Mudur, Ogretmen ve Ogrenci sınıflarını ekleyiniz.
    // YÖNERGE ADIMI: Ogrenci sınıfından temel sınıf kurucusunu çağırınız (: base(ad)).
    class Ogrenci : Insan
    {
        public Ogrenci(string ad) : base(ad)
        {
        }

        // YÖNERGE ADIMI: Insan sınıfındaki Buyu metodunu Ogrenci sınıfından gizleyiniz.
        // YÖNERGE ADIMI: Uyarıyı engellemek için başına "new" sözcüğünü ekleyiniz.
        new public void Buyu()
        {
            this.Boy += 1.5;
            this.Kilo += 1.5;
        }
    }

    class Ogretmen : Insan
    {
        public Ogretmen(string ad) : base(ad)
        {
        }
    }

    class Mudur : Insan
    {
        public Mudur(string ad) : base(ad)
        {
        }
    }
}