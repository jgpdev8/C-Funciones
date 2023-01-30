using System;

namespace FuncionesAdicionales14
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeFechaBonita(28, 2, 2021);
        }
        static void EscribeFechaBonita(int dia, int mes, int anno)
        {
            if (dia>DiasMes2(mes, anno))
            {
                Console.WriteLine("Fecha no válida");
            }
            else
            {
                Console.WriteLine(dia+" de "+MesEnTexto(mes)+" del "+anno);
            }





        }
        static string MesEnTexto(int mes)
        {
            string mes1 = "";
            switch (mes)
            {
                case 1:
                    mes1 = "Enero";
                    break;
                case 2:
                    mes1 = "Febrero";
                    break;
                case 3:
                    mes1 = "Marzo";
                    break;
                case 4:
                    mes1 = "Abril";
                    break;
                case 5:
                    mes1 = "Mayo";
                    break;
                case 6:
                    mes1 = "Junio";
                    break;
                case 7:
                    mes1 = "Julio";
                    break;
                case 8:
                    mes1 = "Agosto";
                    break;
                case 9:
                    mes1 = "Septiembre";
                    break;
                case 10:
                    mes1 = "Octubre";
                    break;
                case 11:
                    mes1 = "Noviembre";
                    break;
                case 12:
                    mes1 = "Diciembre";
                    break;
                default:
                    mes1 = "error";
                    break;

            }
            return mes1;
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