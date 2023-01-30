using System;

namespace FuncionesAdicionales17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FechaCorrecta(31,4,2020));
        }
        static bool FechaCorrecta(int dia,int mes,int anno)
        {
            if (anno < 1980 || anno > 2100)
            {
                return false;
            }
            else
            {
                if (mes<1||mes>12)
                {
                    return false;
                }
                else
                {
                    if (dia > DiasMes2(mes, anno))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
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
    }
}
