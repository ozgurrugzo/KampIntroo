﻿using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            GercekMusteri musteri1= new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Özgür";
            musteri1.Soyadi = "Özyiğit";
            musteri1.TcNo = "1324567890";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Tukan Yazılım";
            musteri2.VergiNo = "123465789";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);







        }
    }
}
