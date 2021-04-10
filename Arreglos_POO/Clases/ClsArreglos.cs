using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_POO.Clases
{
    class ClsArreglos
    {
        private string[] ArregloTemporal;
        private  string[] datos;
        private int i, j;
        private string datoTemporal;
        private  int tamañoArreglo;

        public int GETtamañoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos(string []arreglo)
        {
            datos  = arreglo;
            tamañoArreglo = arreglo.Length;
        }
        
        public string [] MetodoBurbuja()
        {
            ArregloTemporal = datos;
            for (i=0; i < ArregloTemporal.Length - 1; i++)
            {
                for (j = i + 1; j < ArregloTemporal.Length; j++)
                {

                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j])>0)
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
