using System;
using System.Security.Cryptography.X509Certificates;

namespace OdevMetodlarGun3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            void Ekle ()
            {
                Console.WriteLine("Başarıyla Eklendi");
            }

            Ekle();

            //Parametreli metotlar
            void Ekle2 (int sayi1, int sayi2)
            {
                int sonuc = sayi1 + sayi2;
                Console.WriteLine("İşlem sonucu: " +sonuc);
            }

            Ekle2(100, 80);

            //Default parametreli metotlar

            void Ekle3(int sayi1, int sayi2, int sayi3=70,int sayi4=90)
            {
                int sonuc2 = sayi1 + sayi2 + sayi3 + sayi4;
                Console.WriteLine("İşlem sonucu "+sonuc2);
            }

            Ekle3(1, 2, 6);

            //Ref keywordu 

            int sayi5 = 10;
            int sayi6 = 40;


            void Ekle4(  int sayi5, int sayi6)
            {
                sayi5 = 20;
                int sonuc3 = sayi5 + sayi6;
                Console.WriteLine("İşlem sonucu "+sonuc3);
                
            }

            Ekle4(  sayi5, sayi6);

            //Metot overloading

            void Carp(int sayi1,int sayi2)
            {
                int sonuc = sayi1 * sayi2;
                Console.WriteLine("Çarpım sonucu "+sonuc);
            }

            void Carp(int sayi1, int sayi2, int sayi3)
            {
                int sonuc = sayi1 * sayi2 * sayi3;
                Console.WriteLine("Çarpım sonucu " + sonuc);
            }

            Carp(5, 6,5);




















        }
    }
}
