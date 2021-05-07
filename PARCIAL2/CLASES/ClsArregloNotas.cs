using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL2.CLASES
{
    class ClsArregloNotas
    {

        private int datos;
        private int i, j;
        private int datoTemporal;



        public ClsArregloNotas()
        {
        }

        public int[] MetodoBurbujaEnteros(string [,] arreglo,int col)
        {
            int[] ArregloTemporal = new int [arreglo.GetLength(0)];

            for (int i = 1; i < arreglo.GetLength(0); i++)
            {
                
                datos= Int32.Parse(arreglo[i, col]);
                ArregloTemporal[i] = datos;
                
            }

            for (i = 0; i < ArregloTemporal.GetLength(0) - 1; i++)
            {
                for (j = i + 1; j < ArregloTemporal.GetLength(0); j++)
                {

                    if (ArregloTemporal[i]>ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }

                }
            }

            return ArregloTemporal;
        }
        
    }
}
