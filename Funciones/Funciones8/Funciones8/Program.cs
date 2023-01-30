using System;

namespace Funciones8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Maximo común divisor");
            Console.WriteLine("Dime el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(mcd(a, b));
        }
        static int mcd(int a, int b)
        {
            int i, max=0;
            if (a >= b)
            {
                for (i = 1; i <= b; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        max = i;
                    }
                }
            }
            else
            {
                for (i = 1; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        max = i;
                    }
                }
            }
            return max;
        }
    }
}
