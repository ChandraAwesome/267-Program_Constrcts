using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    public class AgeEligible
    {
        public  void Casting()
        {
            Console.WriteLine("Enter your Age :");
            int age=Convert.ToInt32(Console.ReadLine());

            if(age>=18 && age<=90)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else { Console.WriteLine("Sorry you are eligible for voting"); }
        }
    }
}
