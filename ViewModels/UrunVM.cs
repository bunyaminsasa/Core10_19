using Core10_19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core10_19.ViewModels
{
    public class UrunVM
    {
        public List<Urun> Ürünler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<Marka> Markalar { get; set; }
    }
}
