using System;

namespace Deger_ve_ReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            int sayi1 = 10;
            int sayi2 = 30;
            sayi1= sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1 + "||||" + sayi2);
            int[] sayilar1 = { 10, 20, 30 };
            int[] sayilar2 = { 100, 200, 300 };
            sayilar1= sayilar2; //referanslarini esitledin sayilar1 artik sayilar2ye esit oldu
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

        }
    }
}
