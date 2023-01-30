using System;

namespace Funciones17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
        static int Factorial(int n)
        {
            int i,factorial = 1;
            for (i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
