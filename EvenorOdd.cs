using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    public class EvenorOdd
    {
        public void check()
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("It is a Even Number");
            }
            else { Console.WriteLine("It is an Odd Number"); }
        }
    }
}
