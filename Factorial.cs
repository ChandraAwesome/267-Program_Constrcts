using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    internal class Factorial
    {
        public static void fact()
        {
            Console.WriteLine("Enter the Number");
            int N = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            for(int i=1;i<=N;i++) 
            {
                m = m * i;
            }
            Console.WriteLine("Factorial of " + N + " is " + m);
        }
    }
}
