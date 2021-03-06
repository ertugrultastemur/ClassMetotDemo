using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "Ahmet Gündoğdu";
            musteri1.yas = 36;
            musteri1.sehir = "Bursa";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Isim = "Bengü Tonay";
            musteri2.yas = 26;
            musteri2.sehir = "Adana";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Isim = "Ertuğrul Taştemür";
            musteri3.yas = 20;
            musteri3.sehir = "Istanbul";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager islemler = new MusteriManager();
            islemler.Ekle(musteri1);
            islemler.Cikar(musteri2);
            islemler.Listele(musteriler);

        }
    }
}
