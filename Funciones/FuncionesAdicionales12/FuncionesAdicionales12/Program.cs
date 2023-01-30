using System;

namespace FuncionesAdicionales12
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, longitud;
            Console.WriteLine("Dime la altura");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime la longitud");
            longitud = int.Parse(Console.ReadLine());
            Romboide(altura, longitud);
        }
        static void Romboide(int alt ,int longi)
        {
            int i, j, k;
            for (j = 1; j <= alt; j++)
            {
                for (k = alt; k > j; k--)
                {
                    Console.Write(" ");
                }
                for (i = 1; i <= longi; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
                
            }
        }
    }
}
