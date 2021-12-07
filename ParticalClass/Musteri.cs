using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticalClass
{
    public class Musteri
    {


        public int id { get; set; }
        public string isim { get; set; }
        public string soyIsim { get; set; }
        public string emailAdres { get; set; }


        public int YeniKayit(Musteri m)
        {
            Console.WriteLine("Db Kayıt tamamlandı");
            return 1;
        }

        public int KayitGuncelle(Musteri m)
        {
            Console.WriteLine("Db Kayıt güncellendi");
            return 1;
        }

        public int KayitSil(Musteri m)
        {
            Console.WriteLine("Db Kayıt silindi");
            return 1;
        }

        public Musteri()
        {

        }


    }
}
