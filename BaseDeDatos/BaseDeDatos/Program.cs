using BaseDeDatos.Clases.ArchivoPlano;
using BaseDeDatos.Clases.BaseDatos;
using System;
using System.Data;

namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            Console.WriteLine("\t\t\t¿Que Base de Datos desee utilizar?");
            Console.WriteLine("\tOracle\t\tMySQL\t\tSQL SERVER");
            respuesta = Console.ReadLine();

            string[,] archivoAlumnos;
            ClsArchivo ObjArchivo = new ClsArchivo();
            archivoAlumnos = ObjArchivo.LeerArchivo();
            ClsConexion cn = new ClsConexion();
            ClsConexionMySQL my = new ClsConexionMySQL();
            ClsConexionOracle or = new ClsConexionOracle();

            switch (respuesta)
            {
                case "Oracle":

                    for (int i = 1; i < archivoAlumnos.GetLength(0); i++)
                    {

                        DataTable dt = or.consultaTablaDirecta("insert into TB_ALUMNOSORACLE values (" + archivoAlumnos[i, 0] + ",'" + archivoAlumnos[i, 1] + "'," + archivoAlumnos[i, 2] + "," + archivoAlumnos[i, 3] + "," + archivoAlumnos[i, 4] + ")");

                    }

                    break;

                case "MySQL":                    

                    for (int i = 1; i < archivoAlumnos.GetLength(0); i++)
                    {

                        DataTable dt = my.consultaTablaDirecta("insert into tb_alumnos values (" + archivoAlumnos[i, 0] + ",'" + archivoAlumnos[i, 1] + "'," + archivoAlumnos[i, 2] + "," + archivoAlumnos[i, 3] + "," + archivoAlumnos[i, 4] + ")");

                    }

                    break;

                case "SQL SERVER":
                 
                    for (int i=1; i < archivoAlumnos.GetLength(0); i++)
                    {

                        DataTable dt = cn.consultaTablaDirecta("insert into tb_alumnos values (" + archivoAlumnos[i, 0] + ",'" + archivoAlumnos[i, 1] + "'," + archivoAlumnos[i, 2] + "," + archivoAlumnos[i, 3] + "," + archivoAlumnos[i, 4] + ")");


                    }
                   
                    break;
            }            

        }
    }
}
