using System;

namespace Funciones9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Minimo común múltiplo:");
            Console.WriteLine("Dime el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Mcm(n1,n2));
        }
        static int Mcm(int a, int b)
        {
            int i = a, min = 0;
            while (i <= a * b)
            {
                if (i % a == 0 && i % b == 0)
                {
                    min=i;
                    break;
                    
                }
                i++;
            }
            return min;
        }
    }
}
