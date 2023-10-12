using System;


namespace Bangun_Datar
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Bangun_Datar
    {
        public class BangunDatar 
        {
        
        public double PersegiPanjang(double p, double l)
            {
                return p * l;
            }
        public double persegi(double p)
            {
                return p * p * p * p;
            }
        public double lingkaran(double l)
            {
                return 3.14 * (l * l);
            }
        public double segitiga(double p, double l)
            {
                return 0.5 * (p * l);
            }
        }
            class Program
            {
                static void Main(string[] args)
                {
                    double p = Double.Parse(args[0]);
                    double l = Double.Parse(args[1]);
                    double z = Double.Parse(args[2]);

                    BangunDatar bd = new BangunDatar();

                    double PP = bd.PersegiPanjang(p, l);
                    double PG = bd.persegi(p);
                    double LK = bd.lingkaran(l);
                    double ST = bd.segitiga(p, l);

                    Console.WriteLine("Persegi Panjang = {0}", PP);
                    Console.WriteLine("Persegi = {0}", PG);
                    Console.WriteLine("Lingkaran = {0}", LK);
                    Console.WriteLine("Segitiga = {0}", ST);

                }
            }
        }

    }
