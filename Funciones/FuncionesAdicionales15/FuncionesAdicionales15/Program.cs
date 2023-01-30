using System;

namespace FuncionesAdicionales15
{
    class Program
    {
        static void Main(string[] args)
        {
            listaCuadradosPerfectos(1, 20);
        }
        static bool CuadradoPefecto(double n)
        {
            int i, cont=0;
            for (i = 1; i <= Math.Sqrt(n); i++)
            {
                if (Math.Sqrt(n) % i == 0)
                {
                    cont = cont + 1;
                }

            }
            if (cont > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void listaCuadradosPerfectos(int min,int max)
        {
            int i;
            for (i = min; i < max; i++)
            {
                if (CuadradoPefecto(i))
                {
                    Console.WriteLine(i);
                }
            }
           
        }

            
    }
}
