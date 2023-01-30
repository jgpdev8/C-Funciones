using System;

namespace Funciones11
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1, altura, area;
            Console.WriteLine("Dime la base del triangulo");
            base1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime la altura del triangulo");
            altura = double.Parse(Console.ReadLine());
            area = AreaTriangulo(base1, altura);
            Console.WriteLine(area);
        }
        static double AreaTriangulo(double base1,double altura)
        {
            double area;
            area = ((base1 * altura) / 2);
            return area;
        }
    }
}
