using System;

namespace ClassPekistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 67;

            Kurs kurs2= new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Özgür Özyiğit";
            kurs2.IzlenmeOrani = 99;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Nurhan Özyiğit";
            kurs3.IzlenmeOrani = 97;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + "%" + kurs.IzlenmeOrani);
            }
          


            

        }










        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
        
    }
}
