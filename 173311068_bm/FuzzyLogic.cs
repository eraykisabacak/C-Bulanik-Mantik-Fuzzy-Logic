using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173311068_bm
{
    class FuzzyLogic
    {
        public Hassaslik hassaslik;
        public Miktar miktar;
        public Kirlilik kirlilik;

        public List<double> sonuclar = new List<double>();

        public FuzzyLogic(Hassaslik hassaslik, Miktar miktar, Kirlilik kirlilik)
        {
            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;

            Fuzzy();
        }

        public void Fuzzy()
        {
            hassaslik.HassaslikDurumlari();
            miktar.MiktarDurumlari();
            kirlilik.KirlilikDurumlari();

            Kurallar kurallar = new Kurallar(hassaslik,miktar,kirlilik);
            sonuclar = kurallar.ciktilar();
        }
        
    }
}
