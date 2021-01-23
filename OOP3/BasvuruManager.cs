using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILogerService logerService) //IKrediManager ı verirsem tip olarak bütün kredileri yollayabilirim buraya...
        {
            //Başvuran bilgilerini değerlendirme
            //
            //
            // eğer aşağıdaki gibi yaparsam tüm başvuruları konut kredisine bağımlı hale getiririm bu çok yanlış 
            //KonutKrediManager konutKrediManager = new KonutKrediManager();

            krediManager.Hesapla(); //şimdi hangi krediyi gönderirsem o çalışacak
            logerService.Log();
            

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //listedeki her bir kredinin hesabını yap
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                Console.WriteLine();
            }

        }







    }
}
