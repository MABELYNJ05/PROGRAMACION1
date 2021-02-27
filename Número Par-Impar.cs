using System;

namespace Número_Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            short Numero;
            Console.Write("Ingrese un numero: ");
            Numero = Convert.ToInt16(Console.ReadLine());

            if ((Numero % 2) == 0)
            {
                Console.WriteLine("El numero ingresado es par");

            }
            else
            {
                Console.WriteLine("El numero ingresado es impar");
            }
        }
    }
}
