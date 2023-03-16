using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    internal class Powerof2n
    {
        public static void twopowern()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=n;i++) 
            {
                Console.WriteLine("2^{0}={1}",i,Math.Pow(2,i));
            }
        }
    }
}
