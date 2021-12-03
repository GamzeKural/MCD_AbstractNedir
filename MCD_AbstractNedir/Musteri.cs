using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractNedir
{
    public class Musteri : TemelSinif
    {
        public int musteriID { get; set; }

        public Musteri()
        {
            musteriID = 1;
        }



        public override void TestAbstract()
        {
            Console.WriteLine("musteri => testAbstract");
        }
    }
}
