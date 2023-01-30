using System;

namespace FuncionesAdicionales8
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam;
            Console.WriteLine("Dime el tamaño del cuadrado");
            tam = int.Parse(Console.ReadLine());
            CuadradoEstrellitas(tam);
        }
        static void CuadradoEstrellitas(int tam)
        {
            if (tam < 1 || tam > 20)
            {
                Console.WriteLine("Error de tamaño");
            }
            int i,j;
            for (i = 1; i <= tam;i++)
            {
                for (j = 1; j <= tam; j++)
                {
                    if(i==1 || i == tam)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        
                        if (j > 1 && j < tam)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
