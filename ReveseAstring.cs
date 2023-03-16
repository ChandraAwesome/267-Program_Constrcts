using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Constructs
{
    internal class ReveseAstring
    {
        public static void reverse()
        {
            Console.WriteLine("Enter the word");
            string word=Console.ReadLine();

            char[] words = word.ToCharArray();
            Array.Reverse(words);
            string result=new string(words);
            Console.WriteLine(result);
        }

        public static void reverse1()
        {
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            char[] words = word.ToCharArray();
            for (int i = word.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
