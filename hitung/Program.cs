using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitung
{
    public class BangunRuangK
    {
        public double VolumeKubus(double r)
        {
            return r * r * r;
        }

        public double LuasKubus(double r)
        {
            return 6 * r * r;
        }

    }

    public class BangunRuangB
    {
        public double VolumeBalok(double p, double l, double t)
        {
            return p * l * t;
        }

        public double LuasBalok(double p, double l, double t)
        {
            return 2 * ((p * l) + (p * t) + (l * t));
        }

    }

    public class BangunRuangLSE
    {
        public double VolumeLimasSegiEmpat(double a, double Tl)
        {
            return a * a * Tl * 1 / 3;
        }

        public double LuasLimasSegiEmpat(double a, double ts)
        {
            return (a * a) + (4 * a * ts / 2);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(args[0]);
            double p = double.Parse(args[1]);
            double l = double.Parse(args[2]);
            double t = double.Parse(args[3]);
            double a = double.Parse(args[4]);
            double Tl = double.Parse(args[5]);
            double ts = double.Parse(args[6]);

            BangunRuangK Ku = new BangunRuangK();
            double vk = Ku.VolumeKubus(r);
            double lk = Ku.LuasKubus(r);

            BangunRuangB Ba = new BangunRuangB();
            double vb = Ba.VolumeBalok(p, l, t);
            double lb = Ba.LuasBalok(p, l, t);

            BangunRuangLSE Le = new BangunRuangLSE();
            double vl = Le.VolumeLimasSegiEmpat(a, Tl);
            double ll = Le.LuasLimasSegiEmpat(a, ts);

            Console.WriteLine("Volume Kubus = {0}", vk);
            Console.WriteLine("Luas Kubus = {0}", lk);
            Console.WriteLine("Volume Balok = {0}", vb);
            Console.WriteLine("Luas Balok = {0}", lb);
            Console.WriteLine("Volume Limas Segi Empat = {0}", vl);
            Console.WriteLine("Luas Limas Segi Empat = {0}", ll);
        }
    }
}
