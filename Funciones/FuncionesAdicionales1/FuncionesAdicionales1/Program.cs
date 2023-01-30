using System;

namespace FuncionesAdicionales1
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
            if (PrimosRelativos(a, b) == true)
            {
                Console.WriteLine("son primos relativos");
            }
            else
            {
                Console.WriteLine("no son primos relativos");
            }
        }
        static bool PrimosRelativos(int a,int b)
        {
            int contador=2,i;
            if (a > b)
            {
                for (i = 2; i <= b; i++)
                {
                    if (a % i == 0 && b%i==0)
                    {
                        contador = contador + 1;
                    }
                }
            }
            else
            {
                for (i = 2; i <= a; i++)
                {
                    if (b % i == 0 && a%i==0)
                    {
                        contador = contador + 1;
                    }
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
