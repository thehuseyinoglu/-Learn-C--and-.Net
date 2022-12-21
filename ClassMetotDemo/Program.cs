using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 1,
                Ad = "Berkay",
                Soyad = "Huseyinoglu"
            };
            Musteri musteri2 = new Musteri
            {
                Id = 2,
                Ad = "onur",
                Soyad = "Akkepenek"
            };

            List<Musteri> musteriler = new List<Musteri>();

           MusteriManager result = new MusteriManager();

            musteriler =  result.Ekle(musteri1, musteriler);
            Console.WriteLine("1. musteri eklendi");
            musteriler = result.Ekle(musteri2, musteriler);
            Console.WriteLine("2. musteri eklendi");
            musteriler = result.Sil(musteriler, musteri1.Id);
            Console.WriteLine("musteri 1 sílindi");
            result.Listele(musteriler);





        }
    }
}
