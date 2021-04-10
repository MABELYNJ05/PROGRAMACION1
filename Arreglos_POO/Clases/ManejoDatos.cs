using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_POO.Clases
{
    class ManejoDatos
    {
        public string[] columnas(string[] archivo,int col)
        {
            string[] columns;
            string[] datResult=new string[archivo.Length];
            int contador = 0;
            foreach (string linea in archivo)
            {             
                    columns = linea.Split(';');
                    datResult[contador]=columns[col];
                    contador++;
            }
            return datResult;

        }

        public int sumarNotas(string[] datos)
        {
            int suma = 0;
            for(int i = 0; i < datos.Length; i++)
            {
                suma += int.Parse(datos[i]);
            }
            return suma;
        }

        public decimal Promedio(string[] datos)
        {
            int i;
            decimal promedio = 0;
            for (i = 0; i < datos.Length; i++)
            {
                promedio += int.Parse(datos[i]);
            }
            promedio /= (i+1);
            return promedio;
        }


        public int numeroMayor(string[] datos)
        {
            int Mayor = 0;
            int num=0;
            for(int i = 0; i < datos.Length; i++)
            {
                num = int.Parse(datos[i]);
                if (num > Mayor)
                {
                    Mayor = num;
                }
            }
            return Mayor;
        }

        public int numeroMenor(string[] datos)
        {
            int Menor=int.Parse(datos[0]);
            int num = 0;
            for (int i = 1; i < datos.Length; i++)
            {
                num = int.Parse(datos[i]);
                if (num < Menor)
                {
                    Menor = num;
                }
            }
            return Menor;
        }
       
    }
}
