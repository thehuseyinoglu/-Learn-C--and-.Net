using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Listele(List<Musteri> musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine("Musteri Adi : " + item.Ad);
                Console.WriteLine("Musteri Soyadi : " + item.Soyad);
            }
        }

        public  List<Musteri> Ekle(Musteri musteri , List<Musteri> musteriler )
        {
            musteriler.Add(musteri);

            return musteriler;
        }

        public List<Musteri> Sil(List<Musteri> musteriler , int id  )
        {
            foreach (var item in musteriler)
            {
                if ( item.Id == id) {
                    musteriler.Remove(item);
                    return musteriler;
                }

            }


            return musteriler;
        }
    }
}
