using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhenger

{
    class Program
    {
        static void Main(string[] args)
        {
            kor k1 = new kor();
            k1.SetSugar(15);
            k1.SetTerulet();
            k1.SetKerulet();

            kiir(k1);


            kor k2 = new kor(58);
            k2.SetKerulet();
            k2.SetTerulet();

            kiir(k2);

            Console.ReadKey();
        }

        private static void kiir(kor k)
        {
            Console.WriteLine($"A{k.GetSugar()}sugaru kor kerulet; {k.GetKerulet()},terulete pedig {k.GetTerulet()}");

        }
    }
}
