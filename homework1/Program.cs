using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Jerrad Monagan
 COP 3855
 Homework 1 C# tutorial*/
namespace homework1
{
    class Program
    {
        static bool again = true;
        static void Main(string[] args)
        {
            while (again)
            {
                Console.WriteLine("Enter the first number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter +, -, /, or *:  ");
                String mathOperator = Console.ReadLine();
                Console.Write("Enter the second number:  ");
                int y = int.Parse(Console.ReadLine());
                if (mathOperator == "+")
                {
                    int message = x + y;
                    Console.WriteLine(x + "+" + y + "=" + message);
                }//end if
                else if (mathOperator == "-")
                {
                    int message = x - y;
                    Console.WriteLine(x + "-" + y + "=" + message);
                }//end else if
                else if (mathOperator == "/")
                {
                    int message = x / y;
                    Console.WriteLine(x + "/" + y + "=" + message);
                }//end else if
                else if (mathOperator == "*")
                {
                    int message = x * y;
                    Console.WriteLine(x + "*" + y + "=" + message);
                }//end else if
                else
                {
                    String message = "invalid operator";
                    Console.WriteLine(message);
                }//end else

                Console.WriteLine("Would you like to perform more math? Enter y or n: ");
                String exit = Console.ReadLine();

                if (exit == "n")
                {
                    Environment.Exit(0);
                }//end if
                else
                {
                    again = true;
                }//end else
            }//end while
        }//end main
    }//end program
}//end namespace
