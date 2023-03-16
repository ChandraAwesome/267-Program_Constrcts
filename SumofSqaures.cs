using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    internal class SumofSqaures
    {
        public static void sqaures()
        {
            Console.WriteLine("Enter a Number ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sums = 0;
            Console.WriteLine("Squares of first " + N + " are ");
            for (int i = 1; i <= N; i++)
            {
                var sum = i * i;
                Console.WriteLine(sum);
                 sums = sums + sum;
            }
            Console.WriteLine("Sum of squares is : {0}", sums);
        }
    }
}
