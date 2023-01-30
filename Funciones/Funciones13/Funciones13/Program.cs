using System;

namespace Funciones13
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            Console.WriteLine("Dime la nota");
            nota = double.Parse(Console.ReadLine());
            Console.WriteLine(NotaenTexto(nota));
        }
        static string NotaenTexto(double n)
        {
            string nota;
            if (n >= 9)
            {
                nota = "sobresaliente";
            }
            else
            {
                if (n >= 7)
                {
                    nota = "notable";
                }
                else
                {
                    if (n >= 6)
                    {
                        nota = "bien";
                    }
                    else
                    {
                        if (n>= 5)
                        {
                            nota = "suficiente";
                        }
                        else
                        {
                            nota = "suspenso";
                        }
                    }
                }
            }
            return nota;
        }
    }
}
