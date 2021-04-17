using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL2.CLASES
{
    class ClsArchivo
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
            return lineas;

        }

        public string LeerTodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo, Encoding.Default))
            {
                contenidoArchivo = reader.ReadToEnd();

            }

            return contenidoArchivo;
        }
    }
}
