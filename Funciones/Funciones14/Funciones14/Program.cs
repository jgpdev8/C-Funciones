using System;

namespace Funciones14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = LeeNatural();
            Console.WriteLine(n);
        }
        static int LeeNatural()
        {
            int n;
            Console.WriteLine("Dime un numero natural");
            n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Numero no valido , introducelo de nuevo");
                n = int.Parse(Console.ReadLine());
            }
            return n;
            
        }
    }
}
