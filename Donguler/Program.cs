using System;
using System.ComponentModel.DataAnnotations;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Kampı";
            string kurs2 = "Programlama Temel Kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Kampı", "Programlama Temel Kurs", "Java", "Python", "C#" };
            
            
            //array - diziler

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            


        }
    }
}
