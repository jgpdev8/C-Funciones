using System;

namespace Funciones16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Dime el numero que quieras elevar");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("a cuanto quieres elevarlo?");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Elevado(n1,n2));

        }
        static int Elevado(int a, int b)
        {
            int elevado = 1, i;
            for (i = 1; i <= b; i++)
            {
                elevado = elevado * a;
            }
            return elevado;
            
        }
    }
}
