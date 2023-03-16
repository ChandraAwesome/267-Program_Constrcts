using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
   public class largestnumber
    {
     public  void Three()
        {
            Console.WriteLine("Enter Three Numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c) { Console.WriteLine("Larger Number is :"+a); }
            else if (c > b && c > b) { Console.WriteLine("Larger Number is :" + c); }
            else { Console.WriteLine("Larger Number is :"+b); }
        }
    }
}
