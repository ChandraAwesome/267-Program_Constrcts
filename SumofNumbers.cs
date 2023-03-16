using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    internal class SumofNumbers
    {
        public static void NaturalNumbers()
        {
            int i = 1;
            int result = 0; 
            while(i <=5)
            {
                 result = result + i;
                i++;
                //Console.WriteLine(result);
            }
            Console.WriteLine("Sum of first 5 natural numbers"+result);
        }
    }
}
