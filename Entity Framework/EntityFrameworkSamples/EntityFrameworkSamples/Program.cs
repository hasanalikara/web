using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun k = new Urun();
            k.UrunAdi = "Samsung S6";
            k.Fiyat = 2500;
            k.StokAdedi = 250;

            UrunContext db = new UrunContext();

            db.Urunler.Add(k);
            db.SaveChanges();

            Console.WriteLine("Veri kayıt edildi");

            Console.ReadLine();

        }
    }
}
