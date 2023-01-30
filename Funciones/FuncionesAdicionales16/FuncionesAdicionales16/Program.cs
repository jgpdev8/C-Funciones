using System;

namespace FuncionesAdicionales16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EsPrimo(2));
            DescomponerFactoresPrimos(1045);
        }
        static void DescomponerFactoresPrimos(int n)
        {
            Console.Write("los Factores primos de "+n+" son:");
            int i, num=n;
            for (i = 2; i <= n; i++)
            {
                if (EsPrimo(i))
                {
                    while (n % i == 0)
                    {
                        if (n == num)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write("x" + i);
                        }
                        n = n / i;
                        
                    }
                }
            }
                
            
            
        }
        static bool EsPrimo(int n)
        {
            int i, cont=0;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            if (cont > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
