using System;

namespace FuncionesAdicionales18
{
    class Program
    {
        static void Main(string[] args)
        {
            SumaNumeros(5);
        }
        static void SumaNumeros(int n)
        {
            int i;
            double num,suma=0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Dime el numero a sumar");
                num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    i--;
                }
                else
                {
                    suma = suma + num;
                }
            }
            Console.WriteLine(suma);
        }
    }
}
