using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayi2 nin değerini sayi1 e kopyala sayı 1 ile işim biter o 30 olur sonrasında sayi2nin 65 olması sayi1 i etkilemez
            sayi2 = 65; // sayi1 burada en son 30 olur


            int[] sayilar1 = new int[] { 10,20,30};
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayilar2 nin referans numarasını sayilar1 e aktar sayilar1 ile sayilar2 aynı referansta oluyor.
            sayilar2[0] = 999; // ilk eleman burada 999 olur


        }
    }
}
