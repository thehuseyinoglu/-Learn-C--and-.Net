using System;

namespace denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2= new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(".................");
            }

            Console.WriteLine("------------Methodlar--------------------------");  

            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);
     






            Console.WriteLine("Hello World!");
        }
    }
}
