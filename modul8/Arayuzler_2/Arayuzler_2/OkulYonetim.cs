using System;

namespace Arayuzler
{
    // YÖNERGE ADIMI: IInsan adında bir arayüz (interface) oluşturunuz.
    interface IInsan
    {
        void Buyu();
    }

    // YÖNERGE ADIMI: Kod tekrarını önlemek için OkuyanInsan soyut (abstract) sınıfını oluşturunuz.
    abstract class OkuyanInsan
    {
        public void Oku()
        {
            Console.WriteLine("Okudum.");
        }
    }

    // YÖNERGE ADIMI: Ogrenci ve Ogretmen sınıflarının ortak uygulamayı OkuyanInsan sınıfından 
    // kalıtım yoluyla almasını sağlayıp aynı zamanda IInsan arayüzünü uygulayınız.
    class Ogrenci : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Hızlı büyüdüm.");
        }
    }

    class Ogretmen : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Yavaş büyüdüm.");
        }
    }
}