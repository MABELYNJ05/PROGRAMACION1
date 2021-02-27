using System;

namespace Convertir_Grados_Radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Num = 0;
            float radianes=0, grados=0;
            
            Console.WriteLine("\t\tEstimado usuario presione el numero de la operacion que desea realizar:\n1) Radianes a Grados\n2) Grados a Radianes");
            Num = Convert.ToByte(Console.ReadLine());

            if (Num == 1)
            {
                Console.Write("Ingrese el numero de radianes a convertir: ");
                radianes = Convert.ToInt16(Console.ReadLine());

                grados = (short)(radianes * (180 / 3.14159));
                Console.WriteLine(+radianes+" radianes equivalen a "+grados+"° grados");
            }else if (Num==2)
            {
                Console.Write("Ingrese el numero de grados a convertir: ");
                grados = Convert.ToInt16(Console.ReadLine());

                radianes =(float) (grados * (3.14159 / 180));
                Console.WriteLine(+grados+" grados equivalen a "+radianes+" radianes");

            }else
            {
                Console.WriteLine("Opcion incorrecta");
            }
        }
    }
}
