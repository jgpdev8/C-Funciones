using System;

namespace FuncionesAdicionales4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("A que numero quieres elevar el 2");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Potencia2(n));
        }
        static int Potencia2(int n)
        {
            int i, elevado = 1;
            if (n == 0)
            {
                return 1;
            }
            else
            {
                if (n < 0)
                {
                    return -1;
                }
                else
                {
                    for (i = 1; i <= n; i++)
                    {
                        elevado = elevado * 2;
                    }
                }
            }
            return elevado;
        }
    }
}
