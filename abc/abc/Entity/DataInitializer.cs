using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace abc.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Kamera", Description = "Kamera Ürünleri"},
                new Category(){ Name = "Bilgisayar", Description = "Bilgisayar Ürünleri"},
                new Category(){ Name = "Elektronik", Description = "Elektronik Ürünleri"},
                new Category(){ Name = "Telefon", Description = "Telefon Ürünleri"},
                new Category(){ Name = "Beyaz Eşya", Description = "Beyaz Eşya Ürünleri"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){  Name = "Canon Eos 1200D", Description = "En yeni ve En Profesyonel Kamera", Price = 3749,Stock = 300,isApproved = true,CategoryId= 1,isHome = true},
                new Product(){  Name = "Canon Eos 1000D", Description = "Güzel Bir Kamera", Price = 3099,Stock = 500,isApproved =true,CategoryId=1},
                new Product(){  Name = "Canon Eos 100D", Description = "Orta Derece Bir Kamera", Price = 1749,Stock = 600,isApproved = false,CategoryId=1},
                new Product(){  Name = "Canon Eos 1000D 18-55 nm", Description = "Orta Derece Profesyonel Bir Kamera", Price = 3249,Stock = 300,isApproved = false,CategoryId=1,isHome = true},
                new Product(){  Name = "Canon Eos 700D + 16 Gb Hafıza Kartı", Description = "Orta Derece Kişisel Kullanımlık Uzun ömür Kamera", Price = 2499,Stock = 750,isApproved =true,CategoryId=1,isHome = true},

                new Product(){  Name = "HP 4Gb RAM + 500Gb HDD + 2Gb Ekran Kartı", Description = "Orta Düzey Bir LAPTOP", Price = 2699,Stock = 150,isApproved =true,CategoryId=2},
                new Product(){  Name = "DELL 4Gb RAM + 1Tb HDD + 1Gb Ekran Kartı", Description = "Ofis Kullanımlar İçin Uygun Bir LAPTOP", Price = 2499,Stock = 250,isApproved =true,CategoryId=2},
                new Product(){  Name = "ASUS 8Gb RAM + 1Tb HDD + 4Gb Ekran Kartı", Description = "Yazılımsal Alanda Kullanıma Uygun Bir LAPTOP", Price = 5249,Stock = 300,isApproved =true,CategoryId=2,isHome = true},
                new Product(){  Name = "CASPER 4Gb RAM + 500Gb HDD + 2Gb Ekran Kartı", Description = "Orta Düzey Bir LAPTOP", Price = 3749,Stock = 400,isApproved =true,CategoryId=2},
                new Product(){  Name = "ASUS 8Gb RAM + 500Gb HDD + 2Gb Ekran Kartı", Description = "Orta Düzey Yazılımsal Alanlara Uygun LAPTOP", Price = 4049,Stock = 500,isApproved =false,CategoryId=2,isHome = true},

                new Product(){  Name = "SAMSUNG S6 EDGE 32Gb 2 Gb Ekran Kartı", Description = "Orta Düzey Bir Telefon", Price = 1500,Stock = 250,isApproved =true,CategoryId=4},
                new Product(){  Name = "IPHONE 7S 128Gb 6Gb Ekran Kartı", Description = "En Kaliteli Telefon", Price = 7000,Stock = 400,isApproved =true,CategoryId=4,isHome = true},
                new Product(){  Name = "XIAOMI RedMi Note 8 64Gb 4Gb Ekran Kartı", Description = "Ucuz Ve Neredeyse Çok iyi Telefon", Price = 2500,Stock = 300,isApproved =false,CategoryId=4,isHome = true},
                new Product(){  Name = "SAMSUNG J4+ 32Gb 2Gb Ekran Kartı", Description = "İyi Düzeyde Bir Telefon", Price = 1200,Stock = 100,isApproved =true,CategoryId=4},
                new Product(){  Name = "SAMSUNG J7 Prime 64Gb 2Gb Ekran Kartı", Description = "Orta Düzey Bir Telefon", Price = 1600,Stock = 200,isApproved =true,CategoryId=4,isHome = true}

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}