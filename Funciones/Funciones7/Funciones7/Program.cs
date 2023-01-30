using System;

namespace Funciones7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, menor;
            Console.WriteLine("Dime el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            b = int.Parse(Console.ReadLine());
            menor=min(a, b);
            Console.WriteLine("el menor es "+menor);
        }
        static int min(int a, int b)
        {
            if (a < b)
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
