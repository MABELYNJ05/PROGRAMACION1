using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_POO.Clases
{
    class ClsArchivo
    {
        public string [] LeerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
            return lineas;

        }

        public string LeerTodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using (StreamReader reader =new StreamReader(archivo,Encoding.Default))
            {
                contenidoArchivo = reader.ReadToEnd();

            }

            return contenidoArchivo;
        }


        public string[] cargarDatos(string[] Archivo)
        {
            string[] datos;
            int contador = 0;
            datos = new string[Archivo.Length - 1];
            foreach (string linea in Archivo)
            {
                if (contador != 0)
                {
                    datos[contador - 1] = trozo_cadena(linea, ";");

                }
                contador++;
            }
            return datos;
        }

        public String trozo_cadena(string cadena, string cortar)
        {
            int indice = cadena.IndexOf(cortar);
            indice++;
            string trozo = cadena.Substring(indice, cadena.Length - indice);
            return trozo;
        }



    }
}
