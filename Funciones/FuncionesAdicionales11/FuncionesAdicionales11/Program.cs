using System;

namespace FuncionesAdicionales11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Dime el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el tercer numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Minimo(a,b,c));
            Console.WriteLine(Medio(a,b,c));
            Console.WriteLine(Maximo(a,b,c));
            
        }
        static int Maximo(int a,int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else
            {
                if (b >= a && b >= c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }
        static int Medio(int a, int b, int c)
        {
            if(a>=b && a <= c || a>=c && a<=b)
            {
                return a;
            }
            else
            {
                if (b >= a && b <= c||b>=c&&b<=a)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }
        static int Minimo(int a, int b ,int c)
        {
            if (a <= b && a <= c)
            {
                return a;
            }
            else
            {
                if(b<=a && b <= c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }
    }
}
