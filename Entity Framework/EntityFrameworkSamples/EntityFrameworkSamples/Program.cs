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

            Kategori k = new Kategori();
            k.KategoriAdi = "Telefon";

            UrunContext db = new UrunContext();

            db.Kategoriler.Add(k);
            db.SaveChanges();

            Console.WriteLine("Veri kayıt edildi");

            Console.ReadLine();

        }
    }
}
