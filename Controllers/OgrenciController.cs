using Core10_19.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core10_19.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            Ogrenci o1 = new Ogrenci { ID = 1, Ad = "Benjamin", Bolum = "Software", TC = 11111111111 };
            Ogrenci o2 = new Ogrenci { ID = 2, Ad = "Fatih", Bolum = "Elektrik", TC = 22222222222 };
            Ogrenci o3 = new Ogrenci { ID = 3, Ad = "Yakup", Bolum = "İlahiyat", TC = 33333333333 };
            Ogrenci o4 = new Ogrenci { ID = 4, Ad = "Aysel", Bolum = "Sağlık", TC = 44444444444 };

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(o1);
            ogrenciler.Add(o2);
            ogrenciler.Add(o3);
            ogrenciler.Add(o4);

            return View(ogrenciler);
        }
    }
}
