using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Es2Linbr;

namespace ConsoleEs2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero decimale.");
            try
            {
                double a = double.Parse(Console.ReadLine());
                int n1;
                if (Utilità.VericaIntero(a))
                {
                    Console.WriteLine($"Il numero {a} è intero.");
                    n1 = (int)a;
                }
                else
                {
                    Console.WriteLine($"Il numero {a} non è intero.");
                    n1 = Utilità.Arrotonda(a);
                }
                if (Utilità.Pari_Dispari(n1)) 
                {
                    Console.WriteLine($"Il numero {n1} è pari.");
                }
                else
                {
                    Console.WriteLine($"Il numero {n1} è dispari.");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Si possono inserire solo dei numeri." + e.Message);
            }
                Console.ReadLine();

        }
    }
}
