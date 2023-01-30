using System;

namespace FuncionesAdicionales2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cen, far;
            Console.WriteLine("Dime los grados Farenheit");
            far = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime los grados centigrados");
            cen = double.Parse(Console.ReadLine());
            Console.WriteLine("los grados farenheit son: "+CentigradosaFarenheit(cen));
            Console.WriteLine("los grados centigrados son: "+FarenheitaCentigrados(far));
        }
        static double CentigradosaFarenheit(double n)
        {
            double far;
            far = 1.8 * n + 32;
            return far;
        }
        static double FarenheitaCentigrados(double n)
        {
            double cen;
            cen = (n - 32) / 1.8;
            return cen;
        }
    }
}
