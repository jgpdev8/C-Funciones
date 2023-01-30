using System;

namespace Funciones4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dime el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            b = int.Parse(Console.ReadLine());
            imprimeserie(a, b);
        }
        static void imprimeserie(int a, int b)
        {
            int i;
            if (a < b)
            {
                for (i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (i = a; i >= b; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
