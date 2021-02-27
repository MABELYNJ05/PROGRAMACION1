using System;

namespace Factorial_de_un_Número
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, factorial=1, x=0;
            Console.WriteLine("INTRODUZCA UN NUMERO");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++) 
            {
                x = x + 1;
                factorial = factorial * x;

            }

            Console.WriteLine("El factorial de " + numero + " es " + factorial);
        }
    }
}
