using System;

namespace Funciones5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(positivonegativo(n)); 
        }
        static int positivonegativo(int n)
        {
            if (n > 0)
            {
                return 1;
            }
            else
            {
                if (n == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }


    } 
}
