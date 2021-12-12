using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Kaya";
            musteri1.Yasi = 45;
            musteri1.TcNo = "12345678901";
            musteri1.Id = "000001";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Taş";
            musteri2.Yasi = 39;
            musteri2.TcNo = "98765432109";
            musteri2.Id = "000002";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ayşe";
            musteri3.Soyadi = "Sönmez";
            musteri3.Yasi = 42;
            musteri3.TcNo = "12332178901";
            musteri3.Id = "000003";

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Fatma";
            musteri4.Soyadi = "Kaçar";
            musteri4.Yasi = 60;
            musteri4.TcNo = "10014678901";
            musteri4.Id = "000004";

            Musteri musteri5 = new Musteri();
            musteri5.Adi = "Cenk";
            musteri5.Soyadi = "Soysuzoğlu";
            musteri5.Yasi = 27;
            musteri5.TcNo = "59745678901";
            musteri5.Id = "000005";

            Musteri musteri6 = new Musteri();
            musteri6.Adi = "Pelin";
            musteri6.Soyadi = "Fatmaoğlu";
            musteri6.Yasi = 29;
            musteri6.TcNo = "79345678901";
            musteri6.Id = "000006";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, musteri6 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri4);
            Console.WriteLine(" * ");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri3);
            Console.WriteLine(" * ");
            musteriManager.OzellikListele(musteri4);
            Console.WriteLine(" * ");
            musteriManager.HerkesiListele(musteriler);

        }
    }
}
