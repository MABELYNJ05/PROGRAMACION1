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

        public float promedios_general_seccion(string[,] matriz,int columna_parcial, string seccion)
        {

            float promedio=0;
            int contar_alumnos=0;
            int suma=0;
            for(int i = 1; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5].Equals(seccion))
                {
                    suma += int.Parse(matriz[i, columna_parcial]);
                    contar_alumnos++;
                }
            }
            promedio = suma / contar_alumnos;
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

        public float promedios_por_seccion(string[,] matriz, string seccion)
        {
            //este metodo solo funcionara con la matriz creada a partir de sumatoria general por alumno
            float promedio = 0;
            int contar_alumnos = 0;
            int suma = 0;
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 2]==(seccion))
                {
                    suma += int.Parse(matriz[i, 1]);
                    contar_alumnos++;
                }
            }
            promedio = suma / contar_alumnos;
            return promedio;


        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)//numero/nombre/parcial1/parcial2/parcial3/seccion
        {
            string[,] sumatoria_alumno=new string[65,3];
            int suma = 0;
            int siguiente;
            //hacemos la suma de las columnas de las notas
              for(int i = 1;i<matriz.GetLength(0); i++)
              {
                //quitamos la columna de las secciones con getlength(1)-1
                for (int j = 2;j< matriz.GetLength(1)-1; j++) 
                {
                    try
                    {
                        siguiente = int.Parse(matriz[i, j + 1]);
                    }
                    catch
                    {
                        siguiente = 0;
                    }
                    suma+=int.Parse(matriz[i,j]);
                    sumatoria_alumno[i,0] = matriz[i, 1];
                    sumatoria_alumno[i, 1] = Convert.ToString(suma);
                    sumatoria_alumno[i, 2] = matriz[i, 5];
                }
                suma = 0;
              }
             
        
            
            return sumatoria_alumno;
           
        }


        public string[,] PromedioTotalPorAlumno(string[,] matriz)
        {
            string[,] promedio_Alumno = new string[matriz.GetLength(0), matriz.GetLength(1)];
            float promedio = 0;
            for(int i = 1; i < matriz.GetLength(0); i++)
            {
                //si el dato que tiene matriz es distinto a nulo se ejecutara el if
                if (matriz[i, 0] != null)
                {
                    promedio = int.Parse(matriz[i, 1]) / 3;
                   
                }
                promedio_Alumno[i, 0] = matriz[i, 0];
                promedio_Alumno[i, 1] = Convert.ToString(promedio);
            }
            return promedio_Alumno;
        }

    }
}
