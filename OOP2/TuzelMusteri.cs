using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    // MİRAS (İNHERİTANCE)
    class TuzelMusteri:Musteri //TÜZEL MÜŞTERİ BİR MÜŞTERİDİR , TÜZEL MÜŞTERİNİN EBEVEYNİ MÜŞTERİ
    {
        //BURADA SADECE TÜZEL MÜŞTERİYE AİT ÖZELLİKLER KALDI
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
