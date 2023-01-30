using System;

namespace FuncionesAdicionales3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            calderilla(3.11);
        }
        static void calderilla(double n)
        {
            int nentero = (int) (n*100);
            
            int dinero = 500-nentero;
            int moneda2=0, moneda1=0, moneda50=0, moneda20=0, moneda10=0, moneda5=0, moneda2c=0, moneda1c=0;
            while (dinero > 0)
            {
                if (dinero >= 200)
                {
                    dinero = dinero - 200;
                    moneda2 = moneda2 + 1;
                    Console.WriteLine(dinero);
                }
                else
                {
                    if (dinero >= 100)
                    {
                        dinero = dinero - 100;
                        moneda1 = moneda1 + 1;
                        Console.WriteLine(dinero);
                    }
                    else
                    {
                        if (dinero >= 50)
                        {
                            dinero = dinero - 50;
                            moneda50 = moneda50 + 1;
                            Console.WriteLine(dinero);
                        }
                        else
                        {
                            if (dinero >= 20)
                            {
                                dinero = dinero - 20;
                                moneda20 = moneda20 + 1;
                                Console.WriteLine(dinero);
                            }
                            else
                            {
                                if (dinero >= 10)
                                {
                                    dinero = dinero - 10;
                                    moneda10 = moneda10 + 1;
                                    Console.WriteLine(dinero);
                                }
                                else
                                {
                                    if (dinero >= 5)
                                    {
                                        dinero = dinero - 5;
                                        moneda5 = moneda5 + 1;
                                        Console.WriteLine(dinero);
                                    }
                                    else
                                    {
                                        if (dinero >= 2)
                                        {
                                            dinero = dinero - 2;
                                            moneda2c = moneda2c + 1;
                                            Console.WriteLine(dinero);
                                        }
                                        else
                                        {
                                            dinero = dinero - 1;
                                            moneda1c = moneda1c + 1;
                                            Console.WriteLine(dinero);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("la vuelta seran "+moneda2+" monedas de 2 euros");
            Console.WriteLine("la vuelta seran " + moneda1 + " monedas de 1 euro");
            Console.WriteLine("la vuelta seran " + moneda50 + " monedas de 50cent");
            Console.WriteLine("la vuelta seran " + moneda20 + " monedas de 20cent");
            Console.WriteLine("la vuelta seran " + moneda10 + " monedas de 10cent");
            Console.WriteLine("la vuelta seran " + moneda5 + " monedas de 5cent");
            Console.WriteLine("la vuelta seran " + moneda2c + " monedas de 2cent");
            Console.WriteLine("la vuelta seran " + moneda1c + " monedas de 1cent");
        }
    }
}
