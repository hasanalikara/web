using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_intermediate.Models
{
    public static class Veritabani
    {
        public static List<Urun> _liste;

        public Veritabani()
        {
            _liste = new List<Urun>()
            {
                new Urun(){ UrunId=1,UrunAdi="Samsung S6", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap iLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap i", Fiyat=1000, Satistami=true,Resim="1.jpg"},
                new Urun(){ UrunId=2,UrunAdi="Samsung S7", Aciklama="idare eder", Fiyat=1000, Satistami=false, Resim="2.jpg"},
                new Urun(){ UrunId=3,UrunAdi="Samsung S8", Aciklama="idare eder", Fiyat=2000, Satistami=true, Resim="3.jpg"},
                new Urun(){ UrunId=4,UrunAdi="IPhone 6", Aciklama="idare eder", Fiyat=3000, Satistami=false, Resim="4.jpg"},
                new Urun(){ UrunId=5,UrunAdi="IPhone 7S", Aciklama="idare eder", Fiyat=3000, Satistami=true, Resim="2.jpg"},
                new Urun(){ UrunId=6,UrunAdi="IPhone 7S", Aciklama="idare eder", Fiyat=3000, Satistami=true, Resim="3.jpg"},
                new Urun(){ UrunId=7,UrunAdi="IPhone 7S", Aciklama="idare eder", Fiyat=3000, Satistami=false, Resim="4.jpg"},
                new Urun(){ UrunId=8,UrunAdi="IPhone 7S", Aciklama="idare eder", Fiyat=3000, Satistami=true, Resim="1.jpg"},
                new Urun(){ UrunId=9,UrunAdi="IPhone 7S", Aciklama="idare eder", Fiyat=3000, Satistami=false, Resim="3.jpg"}

            };
        }
        
        public static List<Urun> Liste
        {
            get { return _liste; }
        }

        public static ElemanEkle (Urun entity)
        {
            _liste.Add(entity);
        }

        public static Urun UrunDetay(int urunid)
        {
            Urun entity = null;
            foreach(var urun in _liste)
            {
                if (urun.UrunId == urunid)
                {
                    entity = urun;
                }
            }
            return entity;
        }
    }
}