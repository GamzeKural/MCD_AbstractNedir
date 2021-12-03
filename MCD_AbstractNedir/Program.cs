using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Abstract ve Interface kavramları
             * 
             * Kendimize işi yapacak bir rol model çıkartırız. Nasıl olacağının
             * kurallarını hazırlar ve nesnelerimizde kurallarımızı kullanırız.
             * 
             * Bu bölümde oluşturmuş olduğumuz nesnelerimizi nasıl kurallar ile
             * şartlayabileceğimizi konuşacağız.
             */

            //TemelSinif T1 = new TemelSinif(); //abstract class new anahtar kelimesi ile bir örneği alınamaz.

            SuperMusteri SP1 = new SuperMusteri();
            SP1.TestAbstract();

            Musteri M1 = new Musteri();
            M1.Test();
            M1.TestAbstract();

            Console.ReadKey();
        }
    }
}
