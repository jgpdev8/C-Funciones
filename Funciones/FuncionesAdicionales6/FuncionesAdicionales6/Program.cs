using System;

namespace FuncionesAdicionales6
{
    class Program
    {
        static void Main(string[] args)
        {
            rombo();
        }
        static void rombo()
        {
            Console.WriteLine("dime un numero");
            int n = int.Parse(Console.ReadLine());
            int i,j,k, tam = n * 2, cont = 1;
            for (j = 1; j <= tam +1; j++)
            {
                for (i = 1; i <= tam; i++)
                {
                    if (i != n)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        for (k = 1; k <= cont*2-1; k++)
                        {
                            Console.Write("*");
                        }
                    }
                }
                
                if (j < (tam)/2)
                {
                    n--;
                    cont++;
                }
                else
                {
                    n++;
                    cont--;
                }
                
                Console.WriteLine();
            }
            

            
            
        }
    }
}
