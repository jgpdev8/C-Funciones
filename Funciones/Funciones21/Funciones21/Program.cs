using System;

namespace Funciones21
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mes,anno;
            //Console.WriteLine("Dime el mes");
            //mes = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dime el año");
            //anno = int.Parse(Console.ReadLine());
            //if (Bisiesto(2020))
            //{
            //    Console.WriteLine("si");
            //}
            //Console.WriteLine(DiasTranscurridos1980(4,5,2000));
            //Console.WriteLine(DiasEntreFechas(4,5,2000,5,5,2000));
            //Console.WriteLine(DiaSemanaFecha(13,2,1991));
            Console.WriteLine(HoraASegundos(1, 1, 1));
            EscribeHoraBonita(5, 4, 4);
            EscribeSegundosBonitos(15874);
            Console.WriteLine(SegundosTranscurridos(5,35,20,5,47,20));
            Console.WriteLine(SegundosTranscurridos1980(28, 10, 2021, 2, 43, 15));
            
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
        static int DiasMes2(int mes,int anno)
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
        static bool Bisiesto(int anno)
        {
            if (anno % 4 ==0 || anno % 400 == 0)
            {
                return true;
            }
            else
            {
                if(anno%4 == 0 && anno % 100 == 0)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            
            
        }
        static int DiasTranscurridos(int dia,int mes,int anno)
        {
            int i, dias=0;
            for (i = 1; i < mes; i++)
            {
                dias = dias + DiasMes2(i, anno);
            }

            dias = dias + dia;

            return dias;
        }
        static int DiasTranscurridos1980(int dia,int mes,int anno)
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
        static int DiasEntreFechas(int dia1,int mes1,int anno1,int dia2,int mes2,int anno2)
        {
            int total=0;
            total = DiasTranscurridos1980(dia2, mes2, anno2) - DiasTranscurridos1980(dia1, mes1, anno1);
            return total;
            
        }
        static int DiaSemanaFecha(int dia,int mes,int anno)
        {
            int total;
            total=DiasTranscurridos1980(dia, mes, anno);
            while (total >= 7)
            {
                total = total - 7;
            }

            return total+1;

        }
        static int HoraASegundos(int hora,int min,int seg)
        {
            int total = 0;
            total = total + hora * 3600 + min * 60 + seg;
            return total;
        }
        static void EscribeHoraBonita(int hora,int min,int seg)
        {
            if (hora < 10)
            {
                Console.Write("0"+hora+":");
            }
            else
            {
                Console.Write(hora+":");
            }
            if (min < 10)
            {
                Console.Write("0"+min+":");
            }
            else
            {
                Console.Write(min+":");
            }
            if (seg < 10)
            {
                Console.Write("0"+seg);
            }
            else
            {
                Console.Write(seg);
            }
            Console.WriteLine();
        }
        static void EscribeSegundosBonitos(int seg)
        {
            int hora = 0, min = 0;
            while (seg >= 3600)
            {
                seg = seg - 3600;
                hora = hora + 1;
            }
            while (seg >= 60)
            {
                seg = seg - 60;
                min = min + 1;
            }
            EscribeHoraBonita(hora, min, seg);
            
        }
        static int SegundosTranscurridos(int hora1, int min1, int seg1, int hora2, int min2, int seg2)
        {
            int total = 0;
            total= HoraASegundos(hora2, min2, seg2) - HoraASegundos(hora1, min1, seg1);
            return total;
        }
        static int SegundosTranscurridos1980(int dia,int mes,int anno,int hora, int min,int seg)
        {
            int dias=DiasTranscurridos1980(dia, mes, anno);
            int total = 0;
            total = dias * 24 * 3600;
            total = HoraASegundos(hora, min, seg) + total;
            return total;
        }
    }
    
}
