using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri
            {
                Id=1,
                MusteriNo = "123",
                Adi = "berkay",
                Soyadi = "Huseyinoglu",
                TcNo="21321312312"
            };

            TuzelMusteri musteri2 = new TuzelMusteri
            {
                Id = 2,
                MusteriNo = "3424",
                SirketAdi = "Kodlama.io",
                VergiNo="1234556"
            };

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);


            // sirket adi yok demekki musterileride ayirmamiz gerekiyor
        }
    }
}
