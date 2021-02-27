using System;

namespace Calcuar_impuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero = 0;
            Console.Write("INGRESE UN NUMERO DEL 1 AL 7 PARA DETERMINAR EL DIA: ");
            numero = Convert.ToByte(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("LUNES");
                    break;

                case 2:
                    Console.WriteLine("MARTES");
                    break;

                case 3:
                    Console.WriteLine("MIERCOLES");
                    break;

                case 4:
                    Console.WriteLine("JUEVES");
                    break;

                case 5:
                    Console.WriteLine("VIERNES");
                    break;

                case 6:
                    Console.WriteLine("SABADO");
                    break;

                case 7:
                    Console.WriteLine("DOMINGO");
                    break;
            }
        }
    }
}
