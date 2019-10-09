using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> Kategoriler = new List<Category>()
            {
                new Category() {KategoriAdi="C#"},
                new Category() {KategoriAdi="Asp.net MVC"},
                new Category() {KategoriAdi="Asp.net WebForm"},
                new Category() {KategoriAdi="Windows Form Application"},
            };

            foreach (var item in Kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=1 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(+25), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=1 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=1 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(+10), Anasayfa=true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=2 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-9), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=2 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=false, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=2 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-15), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=3 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(+10), Anasayfa=true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=3 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=3 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=4 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=4 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", CategoryId=4 },
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}