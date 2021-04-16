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
            string Sec = seccion;

            for (int i = 1; i < matriz.GetLength(0); i++)
            {


                if ((seccion == "A") && (seccion == matriz[i, 5]))
                {
                    AlumnosClasificados = new string[i, 0];
                    AlumnosClasificados[i, 0] = matriz[i, 1];

                }
                else if ((seccion == "B") && (seccion == matriz[i, 1]))
                {
                    AlumnosClasificados[i, 1] = matriz[i, 1];

                }
                else if ((seccion == "C") && (seccion == matriz[i, 1]))
                {
                    AlumnosClasificados[i, 2] = matriz[i, 1];
                }

            }

            return AlumnosClasificados;



        }

        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            throw new NotImplementedException();

        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();

        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            throw new NotImplementedException();

        }
    }
}
