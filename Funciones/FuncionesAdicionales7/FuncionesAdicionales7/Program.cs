using System;

namespace FuncionesAdicionales7
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes, anno;
            Console.WriteLine("Dime el mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el año");
            anno = int.Parse(Console.ReadLine());
            CalendarioGrafico(mes, anno);
        }
        static void CalendarioGrafico(int mes,int anno)
        {
            int dia, j, k;
            dia = DiaSemanaFecha(1,mes, anno);
             Console.WriteLine("  L  M  X  J  V  S  D");
            
            Console.WriteLine();
            k = 1;
            
            
            EscribeEspacios(1, mes, anno);
            for (j = 1; j <= DiasMes2(mes,anno); j++)
            {
                if (j < 10)
                {
                    Console.Write("  " + k);
                }
                else
                {
                    Console.Write(" "+ k);
                }
                k++;
                if (dia % 7 == 0)
                {
                    Console.WriteLine();
                }
                dia++;
            }
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
        static int DiasTranscurridos(int dia, int mes, int anno)
        {
            int i, dias = 0;
            for (i = 1; i < mes; i++)
            {
                dias = dias + DiasMes2(i, anno);
            }

            dias = dias + dia;

            return dias;
        }
        static int DiasTranscurridos1980(int dia, int mes, int anno)
        {
            int i, dias = 0;
            for (i = 1980; i < anno; i++)
            {
                if (Bisiesto(i))
                {
                    dias = dias + 366;
                }
                else
                {
                    dias = dias + 365;
                }
            }
            dias = DiasTranscurridos(dia, mes, anno) + dias;
            return dias;
        }
        static int DiaSemanaFecha(int dia, int mes, int anno)
        {
            int total;
            total = DiasTranscurridos1980(dia, mes, anno);
            while (total >= 7)
            {
                total = total - 7;
            }

            return total + 1;

        }
        static void EscribeEspacios(int n,int mes,int anno)
        {
            int dia;
            dia=DiaSemanaFecha(1, mes, anno);
            switch (dia)
            {
                case 2:
                    {
                        Console.Write("   ");
                        break;
                    }
                case 3:
                    {
                        Console.Write("      ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("         ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("            ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("               ");
                        break;
                    }
                case 7:
                    {
                        Console.Write("                  ");
                        break;
                    }
                default:
                    {
                        break;
                    }
                    
            }
        }
        static int DiasMes2(int mes, int anno)
        {

            if (mes == 2 && Bisiesto(anno))
            {


                return 29;

            }
            else
            {
                return DiasMes(mes);
            }

        }
        static int DiasMes(int mes)
        {
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                return 31;
            }
            else
            {
                if (mes == 2)
                {
                    return 28;
                }
                else
                {
                    return 30;
                }
            }
        }
    }
}
