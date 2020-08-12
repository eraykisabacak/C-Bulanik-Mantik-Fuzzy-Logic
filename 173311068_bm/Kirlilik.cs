using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173311068_bm
{
    class Kirlilik
    {
        double kirlilikSayisi;

        public List<string> kirlilikDurumu = new List<string>();

        public List<double> kirlilikMamdani = new List<double>();

        public Kirlilik(double kirlilikSayisi)
        {
            this.kirlilikSayisi = kirlilikSayisi;
        }

        public void KirlilikDurumlari()
        {
            kirlilikDurumu.Clear();

            if (kirlilikSayisi >= 0 && kirlilikSayisi <= 4)
            {
                kirlilikDurumu.Add("Küçük");
                KirlilikYamukSekil(-4, -1.5, 2, 4);
            }

            if(kirlilikSayisi >= 3 && kirlilikSayisi <= 7)
            {
                kirlilikDurumu.Add("Orta");
                KirlilikUcgenSekil(3, 5, 7);
            }

            if (kirlilikSayisi >= 5.5 && kirlilikSayisi <= 10)
            {
                kirlilikDurumu.Add("Büyük");
                KirlilikYamukSekil(5.5, 8, 12.5, 14);
            }
        }

        private void KirlilikUcgenSekil(double x1, double x2, double x3)
        {
            if (kirlilikSayisi == x2)
            {
                kirlilikMamdani.Add(1);
            }
            if (kirlilikSayisi >= x1 && kirlilikSayisi <= x2)
            {
                kirlilikMamdani.Add((kirlilikSayisi - x1) / (x2 - x1));
            }
            if (kirlilikSayisi >= x2 && kirlilikSayisi <= x3)
            {
                kirlilikMamdani.Add((x3 - kirlilikSayisi) / (x3 - x2));
            }
        }

        private void KirlilikYamukSekil(double x1, double x2, double x3, double x4)
        {
            if (kirlilikSayisi >= x1 && kirlilikSayisi <= x2)
            {
                kirlilikMamdani.Add((kirlilikSayisi - x1) / (x2 - x1));
            }
            if (kirlilikSayisi >= x3 && kirlilikSayisi <= x4)
            {
                kirlilikMamdani.Add((x3 - kirlilikSayisi) / (x3 - x2));
            }
            else
            {
                kirlilikMamdani.Add(1);
            }
        }

        string durumu;

        public string KirlilikDurum()
        {
            foreach (string durum in kirlilikDurumu)
            {
                durumu += durum + " ";
            }
            return durumu;
        }
    }
}
