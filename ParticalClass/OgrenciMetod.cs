using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticalClass
{
    /// <summary>
    /// 
    /// Kontrol işlem: Sistem içerisinde öğrenci kayıtlımı 71777000
    /// parametre kotrol İşlemi:Giriş verileri hatalımı 71777001
    /// 
    /// tryCatch:1777002
    /// başarılı:1777003
    /// 
    /// 1777004
    /// 
    /// </summary>
    public partial class Ogrenci
    {
        public int YeniKayit(Ogrenci m)
        {
            Console.WriteLine("Db Kayıt tamamlandı");
            return 1;
        }

        public int KayitGuncelle(Ogrenci m)
        {
            Console.WriteLine("Db Kayıt güncellendi" + m);
            return 1;
        }

        public int KayitSil(Ogrenci m)
        {
            Console.WriteLine("Db Kayıt silindi");
            return 1;
        }

    }
}
