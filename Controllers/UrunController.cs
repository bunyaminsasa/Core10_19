using Core10_19.Models;
using Microsoft.AspNetCore.Mvc;
using Core10_19.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core10_19.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {

            List<Urun> urunler = new List<Urun>
            {
                new Urun { Adı = "Bilgisayar", Fiyat = 10000, Kategori = "Teknoloji", Menşei = "İthal" },
                new Urun { Adı = "Koltuk", Fiyat = 5000, Kategori = "Mobilya", Menşei = "Yerli" },
                new Urun { Adı = "Saat", Fiyat = 3000, Kategori = "Estetik", Menşei = "İthal" },
                new Urun { Adı = "Masa", Fiyat = 7000, Kategori = "Mobilya", Menşei = "Yerli" },
             };

            List<Kategori> kategoriler = new List<Kategori>
            {
                 new Kategori { Ad = "Teknoloji" },
                 new Kategori { Ad = "Mobilya" },
                 new Kategori { Ad = "Estetik" },
                 new Kategori { Ad = "Sanat" },
            };

            List<Marka> markalar = new List<Marka>
            {
                new Marka { MarkaAdı = "Arcelik", Menşei = "Türkiye" },
                new Marka { MarkaAdı = "Mercedes", Menşei = "Almanya" },
                new Marka { MarkaAdı = "Renault", Menşei = "Fransa" },
                new Marka { MarkaAdı = "Apple", Menşei = "Amerika" },
            };

            UrunVM urunVM = new UrunVM();
            urunVM.Ürünler = urunler;
            urunVM.Kategoriler = kategoriler;
            urunVM.Markalar = markalar;

            return View(urunVM);
        }
    }
}
