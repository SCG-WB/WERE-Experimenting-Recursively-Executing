using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WERE_Experimenting_Recursively_Executing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseStringRecursively("notlob"));
            //Console.WriteLine(ReverseStringIteratively("slipup"));
            Console.WriteLine(IterativeFactorial(5));
            Console.WriteLine("What factorial? ");
            try
            {
                Console.WriteLine(RecursiveFactorial(Convert.ToInt32(Console.ReadLine())));
            }
            catch (Exception ex)
            {
                Console.WriteLine("EEK!");
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("Hit enter to exit... ");
            WaitForEnter();
        }

        static void WaitForEnter()
        {
            Console.ReadLine();
        }

        static string ReverseStringIteratively(string input)
        {
            //create an empty temp string

            //iterate backwards through the string and append each char to the temp string

            throw new NotImplementedException();
        }

        static string ReverseStringRecursively(string input)
        {
            // base case: reverse of 1 character is just 1 character
            if (input.Length <= 1)
            {
                return input;
            }
            // recursive case
            else
            {
                char lastChar = input[input.Length - 1];
                // recursive method call
                return lastChar + ReverseStringRecursively(input.Substring(0, input.Length - 1));
            }

        }

        static int IterativeFactorial(int n)
        {
            if (n <= 1) { return 1; } // Google says both 0 and 1 factorial are 1

            int product = 1;
            while (n > 0)
            {
                product = product * n;
                n = n - 1;
            }
            return product;
        }

        static int RecursiveFactorial(int n)
        {
            if (n == 0) { return 1; }
            else
            {
                return n * RecursiveFactorial(n - 1);
            }
        }

        static int IterativeTriangular(int n)
        {
            // Triangular number 4 = 4+3+2+1 = 10
            throw new NotImplementedException();
        }

        static int RecursiveTriangular(int n)
        {
            // Triangular number 4 = 4+3+2+1 = 10
            throw new NotImplementedException();
        }

        static int RecursiveFibonacci(int n)
        {
            // Fib(1) is 0. Fib(2) is 1.
            // Fib(3) is the sum of the previous 2 Fibs: 0 + 1 = 1
            // so Fib(4) is Fib(3) + Fib(2), which is 1 + 1 = 2.
            // Fib(5) = Fib(4) + Fib(3) which is 1 + 2 = 3
            throw new NotImplementedException();
        }
    }
}
