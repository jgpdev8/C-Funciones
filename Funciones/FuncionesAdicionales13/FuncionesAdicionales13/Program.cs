using System;

namespace FuncionesAdicionales13
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaNotaFinal();
        }
        static void CalculaNotaFinal()
        {
            int i;
            double suma=0, media=0, cont=0, nota;
            for (i = 1; i <= 7; i++)
            {
                
                Console.WriteLine("dime la nota");
                nota = double.Parse(Console.ReadLine());
                while (nota < 0 || nota > 10)
                {
                    Console.WriteLine("dime la nota");
                    nota = double.Parse(Console.ReadLine());
                }
                if (nota < 5)
                {
                    cont = cont + 1;
                }
                
               
                suma = suma + nota;
            }
            media = suma / 7;
            if (cont >= 2 && media > 5)
            {
                Console.WriteLine("la nota final es 4");
            }
            else
            {
                if (cont >= 2 && media < 5)
                {
                    Console.WriteLine("la nota final es " + media);
                }
                else
                {
                    Console.WriteLine("la nota final es " + media);
                }
            }
        }
    }
}
