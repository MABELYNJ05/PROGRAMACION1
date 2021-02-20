using System;

namespace Año_Bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            short año;
            string mes;

            Console.Write("Ingrese el año: ");
            año = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ahora ingrese el mes: ");
            mes = Console.ReadLine();

            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {

                switch (mes)
                {
                    case "enero":
                        Console.WriteLine("Enero cuenta con 31 días.");
                        break;

                    case "febrero":
                        Console.WriteLine("Febrero cuenta con 29 días.");
                        break;

                    case "marzo":
                        Console.WriteLine("Marzo cuenta con 31 días.");
                        break;

                    case "abril":
                        Console.WriteLine("Abril cuenta con 30 días.");
                        break;

                    case "mayo":
                        Console.WriteLine("Mayo cuenta con 31 días.");
                        break;

                    case "junio":
                        Console.WriteLine("Junio cuenta con 30 días.");
                        break;

                    case "julio":
                        Console.WriteLine("Julio cuenta con 31 días.");
                        break;

                    case "agosto":
                        Console.WriteLine("Agosto cuenta con 31 días.");
                        break;

                    case "septiembre":
                        Console.WriteLine("Septiembre cuenta con 30 días.");
                        break;

                    case "octubre":
                        Console.WriteLine("Octubre cuenta con 31 días.");
                        break;

                    case "noviembre":
                        Console.WriteLine("Noviembre cuenta con 30 días.");
                        break;

                    case "diciembre":
                        Console.WriteLine("Diciembre cuenta con 31 días.");
                        break;
                }



            }
            else
            {
                switch (mes)
                {
                    case "enero":
                        Console.WriteLine("Enero cuenta con 31 días.");
                        break;

                    case "febrero":
                        Console.WriteLine("Febrero cuenta con 28 días.");
                        break;

                    case "marzo":
                        Console.WriteLine("Marzo cuenta con 31 días.");
                        break;

                    case "abril":
                        Console.WriteLine("Abril cuenta con 30 días.");
                        break;

                    case "mayo":
                        Console.WriteLine("Mayo cuenta con 31 días.");
                        break;

                    case "junio":
                        Console.WriteLine("Junio cuenta con 30 días.");
                        break;

                    case "julio":
                        Console.WriteLine("Julio cuenta con 31 días.");
                        break;

                    case "agosto":
                        Console.WriteLine("Agosto cuenta con 31 días.");
                        break;

                    case "septiembre":
                        Console.WriteLine("Septiembre cuenta con 30 días.");
                        break;

                    case "octubre":
                        Console.WriteLine("Octubre cuenta con 31 días.");
                        break;

                    case "noviembre":
                        Console.WriteLine("Noviembre cuenta con 30 días.");
                        break;

                    case "diciembre":
                        Console.WriteLine("Diciembre cuenta con 31 días.");
                        break;
                }

            }

        }
    }
}