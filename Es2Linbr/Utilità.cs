using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es2Linbr
{
    public class Utilità
    { 
        public static bool VericaIntero(double n)
        {
            int a = (int)n;
            if(a == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Arrotonda(double c)
        {
            int n = (int)(c + 0.5);
            return n;
        }
        public static bool Pari_Dispari(int n1)
        {
            if(n1 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    } 
}
