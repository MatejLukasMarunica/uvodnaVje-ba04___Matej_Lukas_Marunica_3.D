using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVježba04___Matej_Lukas_Marunica_3.D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rez = 0, pret1 = 1, pret2 = 0;

            Console.WriteLine("Unesi broj za n ---> ");
            n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("rezultat Fibonaccijevog niza iznosi 0");
            }

            if (n == 1)
            {
                Console.WriteLine("rezultat Fibonaccijevog niza iznosi 1");
            }

            if (n > 1) { 
            for (int i = 1; i < n; i++)
            {
                rez = pret2 + pret1;
                pret2 = pret1;
                pret1 = rez;


            }
        }
            Console.WriteLine("rezultat Fibonaccijevog niza iznosi" + rez);
            Console.ReadKey();
        }
    }
}
