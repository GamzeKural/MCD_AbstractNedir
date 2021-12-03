using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractNedir
{
    public abstract class TemelSinif
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public TemelSinif()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void Test()
        {
            Console.WriteLine("temel sınıf => test");
        }

        public abstract void TestAbstract(); //metot imzası

    }
}
