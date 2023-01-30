using System;

namespace Funciones1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("dime un numero y te digo si es par o impar");
            n = int.Parse(Console.ReadLine());
            if (Par(n) == true)
            {
                Console.WriteLine("el numero es par");
            }
            else
            {
                Console.WriteLine("el numero es impar");
            }

        }
        static bool Par(int n)
        {
            if (n % 2 == 0)
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
