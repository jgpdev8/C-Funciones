using System;

namespace FuncionesAdicionales19
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionAritmetica(4,1);
        }
        static void FuncionAritmetica(int n1,int n2)
        {
            int k,j;
            string final="";
            k = n2 - n1;
            for (j = 1; j <= 10; j++)
            {
                final = final + n1 + " ";
                n1 = n1 + k;
            }
            Console.WriteLine(final);
        }
    }
}
