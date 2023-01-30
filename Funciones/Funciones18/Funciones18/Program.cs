using System;

namespace Funciones18
{
    class Program
    {
        static void Main(string[] args)
        {
            double pix;
            Console.WriteLine("Dime los megapixeles");
            pix = int.Parse(Console.ReadLine());
            ResolucionCamara(pix);

        }
        static void ResolucionCamara(double n)
        {
            n = n * 1000000;
            double altura, anchura;
            altura = Math.Sqrt(n / (16.0 / 9.0));
            anchura = altura * (16.0 / 9.0);
            Console.WriteLine("la altura es "+altura+" y la anchura es "+anchura);
        }
    }
}
