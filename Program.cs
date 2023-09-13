using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statements_Using_Gender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;

            //NB ! means not, or negation
            if (isMale)
            {
                Console.WriteLine("You are Male");
            }
            else
            {
                Console.WriteLine("You are Female");
            }
            bool isTall = true;
            if (isTall && isMale) {
                Console.WriteLine("You are both male and tall");
            }
            else if (isTall && !isMale) {
                Console.WriteLine("You are a short man");
            }
            else if (!isTall && !isMale)
            {
                Console.WriteLine("You are a neither a man nor tall ");
            }
            else { Console.WriteLine("You are a woman");
            
            }
            Console.Read();

        }




        


    }
}
