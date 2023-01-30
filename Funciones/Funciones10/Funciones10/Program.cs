using System;

namespace Funciones10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());
            if (Primo(n) == true)
            {
                Console.WriteLine("el numero es primo");
            }
            else
            {
                Console.WriteLine("el numero no es primo");
            }
        }
        static bool Primo(int n)
        {
            int contador = 2,i;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    contador = contador + 1;
                    break;
                }
            }
            if (contador == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
