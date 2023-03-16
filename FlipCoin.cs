using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    internal class FlipCoin
    {
        public static void HeadorTail()
        {
            int head = 0;
            int tail = 0;
            Random toss = new Random();
            while (head < 20 || tail < 20)
            {
                int result = toss.Next(0, 2);
                if (result == 0)
                {
                    Console.WriteLine("It is Head");
                    head++;
                }
                else
                {
                    Console.WriteLine("It is Tail");
                    tail++;
                }
            }
            if (head == 20)
            {
                Console.WriteLine("Head wins 20 times");
            }
            else
            {
                Console.WriteLine("Tail wins 20 times");
            }
        }
    }
}
