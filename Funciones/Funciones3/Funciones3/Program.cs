using System;

namespace Funciones3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime el numero que quieres multiplicar");
            n = int.Parse(Console.ReadLine());
            tablamultiplicar(n);
        }
        static void tablamultiplicar(int n)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(n+"x"+i+"="+n*i);
            }
        }
    }
}
