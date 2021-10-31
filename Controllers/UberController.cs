using Core10_19.Models;
using Core10_19.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core10_19.Controllers
{
    public class UberController : Controller
    {
        public IActionResult Index()
        {
            List<Uber> uber = new List<Uber>
            {
                new Uber{ID=1, DriverName="Bunyamin", PassangerName="Serhat", Location="GOP"},
                new Uber{ID=2, DriverName="Fatih", PassangerName="Yusuf", Location="Bayrampasa"},
                new Uber{ID=3, DriverName="Aysel", PassangerName="Edip", Location="Besiktas"},
                new Uber{ID=4, DriverName="Yakup", PassangerName="Senay", Location="Bosna"},
            };

            List<Sertifika> sertifika = new List<Sertifika>
            {
                new Sertifika{ID=1, Name="Kadir", Number=111},
                new Sertifika{ID=2, Name="Elif", Number=222},
                new Sertifika{ID=3, Name="Bekir", Number=333},
                new Sertifika{ID=4, Name="Ferit", Number=444},
            };

            UberVM uberVM = new UberVM();
            uberVM.Uber = uber;
            uberVM.Sertifika = sertifika;
            return View(uberVM);
        }
    }
}
