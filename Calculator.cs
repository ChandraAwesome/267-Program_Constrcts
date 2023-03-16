using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    public class Calculator
    {
        public static void Calculations()
        {
            Console.WriteLine("Enter two numbers");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1: Addition\n" + "2: Subraction\n" + "3: Multiplication\n" + "4: Division"+"Enter the operation value");
            int value=Convert.ToInt32(Console.ReadLine());

            switch(value) 
            {
                case 1: var add = a+b;
                    Console.WriteLine("Additon of :" + a + " " + b + " " + "is :" + add);break;
                case 2:
                    var sub = a - b;
                    Console.WriteLine("Subraction of :" + a + " " + b + " " + "is :" + sub); break;
                case 3:
                    var mul = a * b;
                    Console.WriteLine("Multiplication of :" + a + " " + b + " " + "is :" + mul); break;
                case 4:
                    var div = a / b;
                    Console.WriteLine("Division of :" + a + " " + b + " " + "is :" + div); break;

                    default: Console.WriteLine("Enter the correct data");break;

            }
        }
    }
}
