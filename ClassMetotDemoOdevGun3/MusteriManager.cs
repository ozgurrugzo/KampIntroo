using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoOdevGun3
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Başarıyla eklendi "+ musteri.Ad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Başarıyla silindi "+ musteri.Ad);

        }
    }
}
