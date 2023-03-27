using System;

namespace ClassMetotDemoOdevGun3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.Ad = "Özgür";
            musteri1.Soyad = "Özyiğit";
            musteri1.TCKimlik = 47809531924;

            Ekle(musteri1);
        }
    }
}
