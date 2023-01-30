using System;

namespace FuncionesAdicionales5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TrianguloEstrellitas();
        }
        static void TrianguloEstrellitas()
        {
            Console.WriteLine("dime un numero entre el 3 y el 20");
            int n = int.Parse(Console.ReadLine());
            while (n < 3 || n > 20)
            {
                Console.WriteLine("dime un numero entre el 3 y el 20");
                n = int.Parse(Console.ReadLine());
            }
            int i, j;
            j = n;
            for (j = 1; j <= n; j++)
            {
                for (i = 1; i <= j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
