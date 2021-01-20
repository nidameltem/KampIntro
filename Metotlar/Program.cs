using System;

namespace Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";*/

            string[] meyveler = new string[] { }; // burası string array i

            Urun urun1 = new Urun();//bir class oluşturduk new ile
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };     //burası Urun array i !!!!!!

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");


            }

            Console.WriteLine("-------------METOTLAR------------------");

            SepetManager sepetManager = new SepetManager();

            //encapsulation(kapsülleme)

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //---sepetManager.Ekle(); --- bu halde kaldığında hata vermişti çünkü sepet managerdaki metotun yazımına uymadı parametre istedi...

            //class oluşturmasaydık aşağıdaki gibi yapacaktık sonra dedikki ürünün stok bilgisinide verelim ne yapacağız
            // ekle2 ye gider stok adedi bilgisi gireriz 

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);




        }
    }


}
