using System;

namespace Días_Laborales
{
    class Program
    {
        static void Main(string[] args)
        {
            string diaSemana;
            Console.Write("Escribe un día cualquiera de la semana: ");
            diaSemana = Console.ReadLine();

            switch (diaSemana)
            {
                case "Lunes":
                    Console.WriteLine("Lunes es un día laboral");
                    break;

                case "Martes":
                    Console.WriteLine("Martes es un día laboral");
                    break;

                case "Miercoles":
                    Console.WriteLine("Miercoles es un día laboral");
                    break;

                case "Jueves":
                    Console.WriteLine("Jueves es un día laboral");
                    break;

                case "Viernes":
                    Console.WriteLine("Viernes es un día laboral");
                    break;

                case "Sabado":
                    Console.WriteLine("Sabado no es un día laboral");
                    break;

                case "Domingo":
                    Console.WriteLine("Domingo no es un día laboral");
                    break;
            }



        }
    }
}
