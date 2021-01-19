using System;

namespace OdevClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "Kot Pantolon";
            urun1.urunBeden = 36;
            urun1.urunRenk = "Mavi";
            urun1.urunfiyat = 150;

            Urun urun2 = new Urun();
            urun2.urunAdi = "Ceket";
            urun2.urunBeden = 38;
            urun2.urunRenk = "Sarı";
            urun2.urunfiyat = 225;

            Urun urun3 = new Urun();
            urun3.urunAdi = "Sweatshirt";
            urun3.urunBeden = 36;
            urun3.urunRenk = "Kırmızı";
            urun3.urunfiyat = 154;

            Urun urun4 = new Urun();
            urun4.urunAdi = "Elbise";
            urun4.urunBeden = 40;
            urun4.urunRenk = "Siyah";
            urun4.urunfiyat = 45;

            Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " :  " + urun.urunfiyat + "TL  " +
                    urun.urunBeden + "beden  " + urun.urunRenk + ".");

            }
        }
    }
    class Urun
    {
        public string urunAdi { get; set; }
        public string urunRenk { get; set; }

        public int urunBeden { get; set; }

        public int urunfiyat { get; set; }
    }
}
 
