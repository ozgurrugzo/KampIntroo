﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Başarıyla Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Başarıyla Sepete Eklendi : " + urunAdi);
        }
    }
}
