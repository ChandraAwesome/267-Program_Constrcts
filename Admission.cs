using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
  public class Admission
    {
        public static void Join() 
        {
            Console.WriteLine("Enter your Maths Marks :");
            int maths=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Physics Marks");
            int physics=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry Marks :");
            int chemistry=Convert.ToInt32(Console.ReadLine());

            int overall_marks = (maths + physics + chemistry);

            if((maths>=65 && physics>=55 && chemistry >= 50) || overall_marks>=180)
            { Console.WriteLine("Your are eligible for admission"); }
            else { Console.WriteLine("Better luck next time or can take any other course"); }
        }
    }
}
