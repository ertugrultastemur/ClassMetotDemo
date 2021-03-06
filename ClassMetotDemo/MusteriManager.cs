using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi : "+ musteri.Isim);
        }
        public void Cikar(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi : "+ musteri.Isim);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Isim);
                Console.WriteLine(musteri.yas);
                Console.WriteLine(musteri.sehir);
            }
        }
    }
}
