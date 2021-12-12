using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi. Geldiğinize sevindik: " + musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla kaldırıldı. Gittiğinize üzüldük: " + musteri.Adi);
        }

        public void HerkesiListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("AD: " + musteri.Adi);
                Console.WriteLine("SOYAD: " + musteri.Soyadi);
                Console.WriteLine("YAŞ: " + musteri.Yasi);
                Console.WriteLine("TCNO: " + musteri.TcNo);
                Console.WriteLine("    --------    ");
            }
        }

        public void OzellikListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi);
            Console.WriteLine(musteri.Soyadi);
            Console.WriteLine(musteri.Yasi);
            Console.WriteLine(musteri.TcNo);
            Console.WriteLine(musteri.Id);
        }


    }
}
