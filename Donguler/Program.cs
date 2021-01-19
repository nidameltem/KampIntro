using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirme kursu";
            string kurs2 = "c++";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);


            //KURSLAR ARRAYİNDE BÜTÜN KURSLARI TUTABİLİRİM
            //DEĞİŞKENİN ADI ARTIK STRİNGARRAY

            string[] kurslar = new string[] { "Yazılım geliştirme kursu", "c++" , "Java","C#"};

            for (int i = 0; i <kurslar.Length; i++) // 0 1 ve 2 için çalışacak
            {
                Console.WriteLine(kurslar[i]); //TEK SEFERDE 3 KURSU EKRANA YAZDIRDIM
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
