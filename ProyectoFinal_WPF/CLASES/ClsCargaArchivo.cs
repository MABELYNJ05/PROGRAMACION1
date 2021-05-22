using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_WPF.CLASES
{
    class ClsCargaArchivo
    {
        public ClsCargaArchivo(DataTable dato)
        {
            string datoS = "DPI,NOMBRE,TELEFONO,HABITACIONES,TIPO_ALQUILER,FECHA,PRECIO\n";

            foreach(DataRow x in dato.Rows)
            {
                datoS += ($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]},{x[6]}\n");
            }

            File.WriteAllText($@"C:\Users\alumno\Desktop\Nueva carpeta\Consultas.csv", datoS);


        }
    }
}
