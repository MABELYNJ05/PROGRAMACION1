using System;

namespace Numeros_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=0;
            Console.Write("Ingrese un numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <(a+1); i++)
            {

                if (a % i == 0)
                {

                    b++;

                }

            }

            if (b != 2)
            {

                Console.WriteLine("No es un numero primo");

            }else
            {
                Console.WriteLine("Es un numero primo");
            }

        }
    }
}
