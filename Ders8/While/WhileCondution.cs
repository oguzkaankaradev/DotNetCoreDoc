using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class WhileCondution
    {
        public void CounterWhile()
        {
            int counter = 0;
            while (counter < 10)//kontrol mekanizması
            {

                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++; // Sayaç her adımda 1 artırılır
            }
        }

        public void DoWhile()
        {
            //Do while
            //Do ... while döngüsü kodu enaz birkez çalıştırır, ardından koşulu kontrol eder.
            //koşul false olsabile döngü bir kez çalışır. 

            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }while (counter < 10);//kontrol mekanizması.

            //Sayaç 10 a ulaşana kadar hello world yazdırılacak.
        }

        public void SonsuzDongu()
        {

            ///while                             ///Do..whilw
            ///Döngüden önce kontrol edilir.     /// Döngüden sonra kontrol edilir.
            ///Kşul yanlışsa hiçbiri çalışmaz.   /// Koşul yanlışsa bir kez kalışır
            ///

            int counter = 0;


            while (counter < 10)
            {
                Console.WriteLine("Sonsuz döngü");
                //counter++;
                //sayacı kaldırırsak sonsuz döngüye girer.
            }
        }
    }
}
