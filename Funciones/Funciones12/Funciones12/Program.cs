using System;

namespace Funciones12
{
    class Program
    {
        static void Main(string[] args)
        {
            double pulgadas;
            double centi;
            Console.WriteLine("Dime las pulgadas");
            pulgadas = double.Parse(Console.ReadLine()); ;
            Console.WriteLine("dime los centimetros");
            centi = double.Parse(Console.ReadLine());
            Console.WriteLine(PulgadasaCentimetros(pulgadas));
            Console.WriteLine(CentimetrosaPulgadas(centi));
        }
        static double PulgadasaCentimetros(double n)
        {
            double centi;
            centi = n * 2.54;
            return centi;
        }
        static double CentimetrosaPulgadas(double n)
        {
            double pulgadas;
            pulgadas = n / 2.54;
            return pulgadas;
        }
    }
}
