using System;

namespace Calcular_Perimetro_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero = 0;
            string Verif;
            short Lados=0, Longitud=0, perimetro=0, apotema=0, area=0, angulo=0;
            
            Console.WriteLine("\t\t\tEstimado usuario, ingrese el numero de la opcion que desea relalizar");
            Console.WriteLine("Opcion 1= Calcular Perimetro\nOpcion 2= Calcular Area");
            numero = Convert.ToByte(Console.ReadLine());

            if (numero == 1)
            {
                Console.Write("Ingrese el numero de lados del poligono: ");
                Lados = Convert.ToInt16(Console.ReadLine());
                Console.Write("Ingrese la longitud de uno de los lados: ");
                Longitud = Convert.ToInt16(Console.ReadLine());

                perimetro = (short)(Lados * Longitud);

                Console.WriteLine("El perimetro del poligono es de "+perimetro);

            }else if (numero == 2)
            {
                Console.Write("Ingrese el perimetro del poligono: ");
                perimetro = Convert.ToInt16(Console.ReadLine());
                Console.Write("Ingrese el apotema Del poligono: ");
                apotema = Convert.ToInt16(Console.ReadLine());

                area = (short)((perimetro * apotema) / 2);

                Console.WriteLine("El area del piligono es " + area);
            }
            else
            {
                Console.WriteLine("Opcion incorrecta");
            }

        }
    }
}
