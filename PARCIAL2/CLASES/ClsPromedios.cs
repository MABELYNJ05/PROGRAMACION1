using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL2.CLASES
{
    class ClsPromedios : InterfacePromedios
    {
        

        public ClsPromedios()
        {

        }

        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            string[,] AlumnosClasificados = new string[20,3];
            int contador = 0;
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                if ((seccion == "A") && (seccion == matriz[i, 5]))
                {
                    AlumnosClasificados[contador, 0] = matriz[i, 1];
                    contador++;

                }
                else if ((seccion == "B") && (seccion == matriz[i, 5]))
                {
                    AlumnosClasificados[contador, 1] = matriz[i, 1];
                    contador++;
                }
                else if ((seccion == "C") && (seccion == matriz[i, 5]))
                {
                    AlumnosClasificados[contador, 2] = matriz[i, 1];
                    contador++;
                }

            }

            return AlumnosClasificados;
        }

        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int columna = columna_parcial;
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);



            for (int fila = 1; fila < totalFilas; fila++)
            {
                if ((seccion == "A") && (seccion == matriz[fila, 5]))
                {
                    acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);

                }
                else if ((seccion == "B") && (seccion == matriz[fila, 5]))
                {
                    acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);

                }
                else if ((seccion == "C") && (seccion == matriz[fila, 5]))
                {
                    acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);

                }

            }

            promedio = acumulador / (totalFilas - 1);
            return promedio;            

        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int columna = columna_parcial;
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);

            for (int fila = 1; fila < totalFilas; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);

            }
            promedio = acumulador / (totalFilas - 1);
            return promedio;

        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();

        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {


        }
    }
}
