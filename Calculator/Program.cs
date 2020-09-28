using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(num1 + " plus 1 is: " + (num1 + 1));
              Console.WriteLine(num1 + " subtracted by 1 is: " + (num1 - 1));
              Console.WriteLine(num1 + " divided by 1 is: "+ (num1 / 1));
              Console.WriteLine(num1 + " multiplyed by 1 is: " + (num1*1));
              Console.WriteLine(num1 + " ++ is: "+ (num1 + 1));
              Console.WriteLine(num1 + " -- is: "+ (num1 - 1));
            */
            Console.WriteLine("Welcome to the Calculator! Give me the two numbers first please: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("What operation would you like to do? add, sub, mult or div?");
            String operation = Console.ReadLine();
            switch(operation)
            {
                case "add":
                    Console.WriteLine(num1 + " added to " + num2 + " equals: " + (num1 + num2));
                    break;
                case "sub":
                    Console.WriteLine(num1 + " subtracted by " + num2 + " equals: " + (num1 - num2));
                    break;
                case "mult":
                    Console.WriteLine(num1 + " multiplied by " + num2 + " equals: " + (num1 * num2));
                    break;
                case "div":
                    Console.WriteLine(num1 + " divided by " + num2 + " equals: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("That is not an indicated operation. Try again");
                    break;

            }


        }
    }
}
