using System;

namespace Funciones15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n;
            Console.WriteLine("Dime el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            n = LeeNumero(n1,n2);
            Console.WriteLine(n);

        }
        static int LeeNumero(int a, int b)
        {
            int n;
            Console.WriteLine("Dime un numero entre "+a+" y "+b);
            n = int.Parse(Console.ReadLine());
            if (a > b)
            {
                while(n>a || n < b)
                {
                    Console.WriteLine("Dime un numero entre "+a+" y "+b);
                    n = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                while (n < a || n > b)
                {
                    Console.WriteLine("Dime un numero entre "+a+" y "+b);
                    n = int.Parse(Console.ReadLine());
                }
            }
            return n;
        }
    }
}
