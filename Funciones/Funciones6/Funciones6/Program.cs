using System;

namespace Funciones6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, mayor;
            Console.WriteLine("Dime el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            b = int.Parse(Console.ReadLine());
            mayor=max(a, b);
            Console.WriteLine("el mayor es "+mayor);
        }
        static int max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
