using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050.ahosszabbikszo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy szót! ");
            string szo1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Kérek még egy szót és kiírom a hosszabbikat! ");
            string szo2 = Convert.ToString(Console.ReadLine());

            if (szo1.Length > szo2.Length)
            {
                Console.WriteLine("Az első szó " + szo1 + " hosszabb, mint a második " + szo2 + " szó.");
                Console.WriteLine("Az első szó " + szo1.Length + " karakter hosszú, a második szó " + szo2.Length + " karakter hosszú.");
            }

            else if (szo2.Length > szo1.Length)
            {
                Console.WriteLine("A második szó " + szo2 + " hosszabb, mint az első " + szo1 + " szó.");
                Console.WriteLine("A második szó " + szo2.Length + " karakter hosszú, az első szó " + szo1.Length + " karakter hosszú.");
            }

            else
            {
                Console.WriteLine("A két szó egyforma hosszú.");
                Console.WriteLine("Az első szó is " + szo1.Length + " karakter hosszú, a második szó is " + szo2.Length + " karakter hosszú.");
            }

            Console.ReadKey();
        }
    }
}
