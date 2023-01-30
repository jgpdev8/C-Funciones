using System;

namespace FuncionesAdicionales10
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeSerieNumero3();
        }
        static void EscribeSerieNumero3()
        {
            int num1, num2, num3,i;
            Console.WriteLine("Dime el primer numero");
            num1 = int.Parse(Console.ReadLine());
            while (num1 < 1 ||num1 > 100)
            {
                Console.WriteLine("Dime el primer numero");
                num1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dime el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            while (num2 < num1 ||num2 > 100)
            {
                Console.WriteLine("Dime el segundo numero");
                num2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dime el tercer número");
            num3 = int.Parse(Console.ReadLine());
            while (num3 < num1 || num3 > num2)
            {
                Console.WriteLine("Dime el tercer número");
                num3 = int.Parse(Console.ReadLine());
            }
            for( i = num1; i <= num3; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for (i = num3; i <= num2; i++)
            {
                Console.Write(i+" ");
            }
        }
    }
}

