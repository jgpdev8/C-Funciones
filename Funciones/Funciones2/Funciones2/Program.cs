using System;

namespace Funciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anno;
            Console.WriteLine("dime el año para saber si es o no bisiesto");
            anno = int.Parse(Console.ReadLine());
            if (bisiesto(anno) == true)
            {
                Console.WriteLine("el año es bisiesto");
            }
            else
            {
                Console.WriteLine("el año no es bisiesto");
            }
        }
        static bool bisiesto(int anno)
        {
            if (anno % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
