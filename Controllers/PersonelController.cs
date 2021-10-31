using Core10_19.Models;
using Core10_19.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core10_19.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            Personel p1 = new Personel { ID = 1, Name = "Bunyamin", Departman = "Software", Salary =30000 };
            Personel p2 = new Personel { ID = 2, Name = "Fatih", Departman = "Elektrik", Salary =40000 };
            Personel p3 = new Personel { ID = 3, Name = "Aysel", Departman = "Eczacı", Salary =30000 };
            List<Personel> personeller = new List<Personel>();
            personeller.Add(p1);
            personeller.Add(p2);
            personeller.Add(p3);

            Departman d1 = new Departman { ID = 1, Name = "Muhasebe" };
            Departman d2 = new Departman { ID = 2, Name = "Yazılım" };
            Departman d3 = new Departman { ID = 3, Name = "Satış Danışmanı" };
            Departman d4 = new Departman { ID = 4, Name = "Kargocu" };

            List<Departman> departmanlar = new List<Departman>();
            departmanlar.Add(d1);
            departmanlar.Add(d2);
            departmanlar.Add(d3);
            departmanlar.Add(d4);

            PersonelVM personelVM = new PersonelVM();
            personelVM.Personeller = personeller;
            personelVM.Departmanlar = departmanlar;



            return View(personelVM);

        }
    }
}
