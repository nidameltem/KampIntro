using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // interface yaptım çünkü eğer bir sınıf bu interface i kullanırsa aşağıdaki metotları içermek zorunda
    //bütün yeni krediler oluşturulduğunda bu hesapla ve bişeyyap ı içermek zorunda
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
