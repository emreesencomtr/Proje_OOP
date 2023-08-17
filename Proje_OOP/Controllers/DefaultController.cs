using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;


namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //private object class1;

        //void islemler()
        //{
        //    Class1 c = new Class1();

        //    c.Topla();
        //}

        void messages()
        {
            ViewBag.m1 = "****Galatasaray****";
            ViewBag.m2 = "Şampiyon Galatasaray'ın bugün : 08.08.2023 Salı Günü Şampiyonlar Ligi 3.Ön Eleme Tur maçı var.";
            ViewBag.m3 = "Saat 22:00'da başlayacak maç için Galatasarayımıza başarılar dilerim.";


        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;    
            int sonuc= s1 + s2;
            return (sonuc);
        }

        int cevre()
        {
            int kisa = 10;
            int uzun = 20;  
            int c = 2 * (kisa + uzun);
            return (c); 
            
        }

        string metin()
        {
            string metin = "Şampiyon Galatasaray 08.08.2023 tarihinde Şampiyonlar Ligi 3.Ön Ödemeler turu ilk maçında 0-3 kazandı";
            return (metin);

        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        int toplama(int s1, int s2)
        {
            int tsonuc = s1 + s2;
            return (tsonuc);
        }
        public IActionResult Index()
        {
            messages();
            MesajListesi("Mertens");
            ViewBag.g = toplama(10, 20);
            return View();
        }

        public IActionResult Urunler()

        {
            messages();
            ViewBag.t= topla();
            ViewBag.c= cevre();
            MesajListesi("İcardi");
            return View();
        }

        public IActionResult Musteriler()
        {
            ViewBag.deger = metin();
            MesajListesi("Bakambu");
            return View();
        }

        public IActionResult Deneme()
        {
           Sehirler sehirler = new Sehirler();
            sehirler.Ad = "Kiev";
            sehirler.Id = 1;
            sehirler.Nufus = 10000000;
            sehirler.Ulke = "Ukrayna";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";

            ViewBag.v1=sehirler.Id;
            ViewBag.v2=sehirler.Ulke;
            ViewBag.v3=sehirler.Ad;
            ViewBag.v4=sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;

            sehirler.Id = 2;
            sehirler.Ad = "Üsküp";
            sehirler.Ulke = "Makedonya";
            sehirler.Nufus = 50000;
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Sarı";

            ViewBag.z1=sehirler.Id;
            ViewBag.z2=sehirler.Ulke;
            ViewBag.z3= sehirler.Ad;
            ViewBag.z4 =sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;

            return View();
        }
    }

}
