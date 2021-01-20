using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //yukarıdaki ile aynı işlem 

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            /* ÖRNEK
             * 
             * 
             * 
            productManager.Topla2(3, 6); //bu toplamı başka bir yerde kullanmak istiyorsam yapamam çünkü void yaptım

            int toplamaSonucu = productManager.Topla(3, 6); // bakınız topla dan bunu yapabiliyorum 

            Console.WriteLine(toplamaSonucu*2);

            /*

            int sayi = 100;
            productManager.Test(sayi);
            Console.WriteLine(sayi); //100  değer tip olduğu için 100 oldu 
            *
            *
            *
            *
            */
            
        }
    }
}
