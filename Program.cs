using Program_Constructs;

namespace Program_Constructs
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FlipCoin.HeadorTail();
            //ReveseAstring.reverse();
            //ReveseAstring.reverse1();
            //SumofNumbers.NaturalNumbers();


            //Console.WriteLine("Hello, World!");
            EqualorNot obj = new EqualorNot();
            //obj.Numbers();
            //
            EvenorOdd obj1 = new EvenorOdd();
            //obj1.check();
            //
            AgeEligible result = new AgeEligible();
            //result.Casting();
            //
            largestnumber num = new largestnumber();
            //num.Three();
            //
            //Admission joining = new Admission();
            // Admission.Join();
            Console.WriteLine("1 : EEqualorNo \n" + "2 :  EvenorOdd\n" + "3: AgeEligible \n" + "4: largestnumber \n" + "5: Admission\n" + "6: WeekDays \n" + "7: Calulator \n"
                + "8: Powersof2 Table\n" + "9: Sum of Squares\n" + "10: Factorial of a Number\n" + "11: FlipCoin\n" + "12: Reverse a Number\n" + "14: Another method\n" + "13: Sum of Natural Numebers"); 
            int k = 0;
            while (k <= 1)
            {
                Console.WriteLine("ENTER THE PROGRAM NUMBER"); 
                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1: obj.Numbers(); break;
                    case 2: obj1.check(); break; 
                    case 3: result.Casting(); break;
                    case 4: num.Three(); break;
                    case 5: Admission.Join(); break;
                    case 6: WeekDays.Day(); break;
                    case 7: Calculator.Calculations(); break;
                    case 8: Powerof2n.twopowern(); break;
                    case 9: SumofSqaures.sqaures(); break;
                    case 10: Factorial.fact(); break;
                    case 11: FlipCoin.HeadorTail();break;
                    case 12: ReveseAstring.reverse();break;
                    case 14: ReveseAstring.reverse1();break;
                    case 13: SumofNumbers.NaturalNumbers();break;

                    default: Console.WriteLine("Enter correct program number"); break;
                }

            }
        }
    }
} 