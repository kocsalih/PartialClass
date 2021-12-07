using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.isim = "salih";
            M1.soyIsim = "koç";
            M1.emailAdres = "Salih@gmail.com";

            int sonuc = M1.YeniKayit( M1);
            if (sonuc>0)
            {
                Console.WriteLine("DAtabase yenik kayit");
            }

            Ogrenci o1 = new Ogrenci();
            o1.id = 2;
            int ogrenciKayitSonuc = o1.YeniKayit(o1);

            if (ogrenciKayitSonuc==71777000)
            {

            }

            else if (ogrenciKayitSonuc == 71777001)
            {

            }

            else if (ogrenciKayitSonuc == 71777002)
            {

            }

            else if (ogrenciKayitSonuc == 71777003)
            {

            }

            else if (ogrenciKayitSonuc == 71777004)
            {

            }

            // M1.KayitGuncelle("");
        }
    }
}

















