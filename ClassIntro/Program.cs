using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Kurs kurs1 = new Kurs(); //KURS1 İM VAR TİPİ KURS (ÖNEMLİ) 
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Meltem";
            kurs1.IzlenmeOrani = 36 ;


            Kurs kurs2 = new Kurs(); //KURS1 İM VAR TİPİ KURS (ÖNEMLİ) 
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Nida";
            kurs2.IzlenmeOrani = 56;

            Kurs kurs3 = new Kurs(); //KURS1 İM VAR TİPİ KURS (ÖNEMLİ) 
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Eda";
            kurs3.IzlenmeOrani = 76;

            Kurs kurs4 = new Kurs(); //KURS1 İM VAR TİPİ KURS (ÖNEMLİ) 
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Dilo";
            kurs4.IzlenmeOrani = 46;

            /*
            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen);
            Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen);
            */

            //yukarıdaki gibi tek tek konsolla kurs adı eğitmen adı yazamam o yüzden dizi oluşturacağım aşağıdaki gibi

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 }; 
            //dizinin içerisinde KURS TUTUYORUM... string falan değil kurs veri tipi bunu biz oluşturduk

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

        }

    }

    class Kurs //KURS CLASS IMIN BİR SÜRÜ DEĞERİ VAR EĞİTMEN ,İZLENME ORANI...
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }

}
