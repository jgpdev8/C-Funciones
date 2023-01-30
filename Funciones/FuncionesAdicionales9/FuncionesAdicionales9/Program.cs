using System;

namespace FuncionesAdicionales9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los años Bisiestos del Siglo XXI: ");
            BisiestosXXI();
        }

        static bool Bisiesto(int anno)
        {
            if (anno % 4 == 0 || anno % 400 == 0)
            {
                return true;
            }
            else
            {
                if (anno % 4 == 0 && anno % 100 == 0)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }


        }
        static void BisiestosXXI()
        {
            int i;
            for (i = 2000; i <= 2100; i++)
            {
                if (Bisiesto(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}