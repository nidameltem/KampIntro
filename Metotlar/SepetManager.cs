using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Urun urun) //Urun class ı ilgili elemanları tutuyordu
        {

            Console.WriteLine("Tebrikler Sepete Eklendi :" + urun.Adi);

        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat) //böyle yazmak doğru değil
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :" + urunAdi);
        }


    }
}
