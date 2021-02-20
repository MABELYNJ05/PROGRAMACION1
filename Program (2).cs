using System;

namespace Calcular_Salario_Semanal
{
    class Program
    {
        static void Main(string[] args)
        {
            byte horasTrabajadas;
            byte horasExtra;
            ushort sueldo;

            Console.Write("Ingrese el numero de horas que trabajó en la semana: ");
            horasTrabajadas = Convert.ToByte(Console.ReadLine());

            if (horasTrabajadas <= 40)
            {
                sueldo = (ushort)(horasTrabajadas * 16);
                Console.WriteLine("Su sueldo es de Q."+sueldo+".00");

            }else if (horasTrabajadas > 40)
            {
                horasExtra = (byte)(horasTrabajadas - 40);
                horasExtra = (byte)(horasExtra * 20);
                sueldo = (ushort)(40 * 16 + horasExtra);
                Console.WriteLine("Su sueldo es de Q."+sueldo+".00");
            }


        }
    }
}
