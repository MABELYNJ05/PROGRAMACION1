using PARCIAL2.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL2
{
    public partial class Form1 : Form
    {
        string[,] ArregloDosDimensiones;
        private string[] ArregloNombres;
        private string[,] Nombres;
        private int[] NotasParcial1;
        private int[] NotasParcial2;
        private int[] NotasParcial3;
        private string[,] sumaNotas_Alumnos;
        private string[,] AlumnosSeccionA;
        private string[,] AlumnosSeccionB;
        private string[,] AlumnosSeccionC;      
        private int PromedioParcial1;
        private int PromedioParcial2;
        private int PromedioParcial3;
        private float promedioTotalSeccionA;
        private float promedioTotalSeccionB;
        private float promedioTotalSeccionC;
        private float PGSAparcial1;
        private float PGSBparcial1;
        private float PGSCparcial1;
        private float PGSAparcial2;
        private float PGSBparcial2;
        private float PGSCparcial2;
        private float PGSAparcial3;
        private float PGSBparcial3;
        private float PGSCparcial3;

        private string[,] promedio_Alumno;




        private int X = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click_1(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo Plano";
            ofd.InitialDirectory = @"C:\Users\cmabe\OneDrive\Escritorio\C# Arreglos\archivoPlano.csv";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNombres = ar.LeerArchivo(archivo);
                textBoxContenido.Text = resultado;


            }
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            int acumulador = 0;


            ArregloDosDimensiones = new string[ArregloNombres.Length, 6];


            foreach (string linea in ArregloNombres)
            {
                string[] datos = linea.Split(';');

                ArregloDosDimensiones[acumulador, 0] = datos[0];
                ArregloDosDimensiones[acumulador, 1] = datos[1];
                ArregloDosDimensiones[acumulador, 2] = datos[2];
                ArregloDosDimensiones[acumulador, 3] = datos[3];
                ArregloDosDimensiones[acumulador, 4] = datos[4];
                ArregloDosDimensiones[acumulador, 5] = datos[5];
                acumulador++;

            }   


            ClsArreglos ObjArreglo = new ClsArreglos(ArregloDosDimensiones);
            Nombres = ObjArreglo.MetodoBurbujaCadenas(1);

            for (int i = 1; i < ArregloDosDimensiones.GetLength(0); i++)
            {
                listBoxNombres.Items.Add(Nombres[i, 1]);
            }

            ClsArregloNotas ObjArregloNotas = new ClsArregloNotas();
            NotasParcial1 = ObjArregloNotas.MetodoBurbujaEnteros(ArregloDosDimensiones, 2);
            NotasParcial2 = ObjArregloNotas.MetodoBurbujaEnteros(ArregloDosDimensiones, 3);
            NotasParcial3 = ObjArregloNotas.MetodoBurbujaEnteros(ArregloDosDimensiones, 4);

            ClsPromedios ObjPromedios = new ClsPromedios();
            AlumnosSeccionA = ObjPromedios.Clasificar_Alumnos(ArregloDosDimensiones, "A");
            AlumnosSeccionB = ObjPromedios.Clasificar_Alumnos(ArregloDosDimensiones, "B");
            AlumnosSeccionC = ObjPromedios.Clasificar_Alumnos(ArregloDosDimensiones, "C");

            PGSAparcial1 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 2, "A");
            PGSBparcial1 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 2, "B");
            PGSCparcial1 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 2, "C");
            PGSAparcial2 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 3, "A");
            PGSBparcial2 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 3, "B");
            PGSCparcial2 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 3, "C");
            PGSAparcial3 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 4, "A");
            PGSBparcial3 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 4, "B");
            PGSCparcial3 = ObjPromedios.promedios_general_seccion(ArregloDosDimensiones, 4, "C");            

            PromedioParcial1 = ObjPromedios.promedios_por_parcial(ArregloDosDimensiones,2);
            PromedioParcial2 = ObjPromedios.promedios_por_parcial(ArregloDosDimensiones,3);
            PromedioParcial3 = ObjPromedios.promedios_por_parcial(ArregloDosDimensiones,4);

            sumaNotas_Alumnos = ObjPromedios.sumatoria_general_por_alumno(ArregloDosDimensiones);
            promedioTotalSeccionA = ObjPromedios.promedios_por_seccion(sumaNotas_Alumnos,"A");
            promedioTotalSeccionB = ObjPromedios.promedios_por_seccion(sumaNotas_Alumnos, "B");
            promedioTotalSeccionC = ObjPromedios.promedios_por_seccion(sumaNotas_Alumnos, "C");
            promedio_Alumno = ObjPromedios.PromedioTotalPorAlumno(sumaNotas_Alumnos);
          


        }

        private void buttonParcial1_Click(object sender, EventArgs e)
        {
            X = 1;
            listBoxResultados.Items.Clear();
            for (int i = 1; i < ArregloDosDimensiones.GetLength(0); i++)
            {
                listBoxResultados.Items.Add(NotasParcial1[i]);
            }

        }

        private void buttonParcial2_Click(object sender, EventArgs e)
        {
            X = 2;
            listBoxResultados.Items.Clear();
            for (int i = 1; i < ArregloDosDimensiones.GetLength(0); i++)
            {
                listBoxResultados.Items.Add(NotasParcial2[i]);
            }

        }

        private void buttonParcial3_Click(object sender, EventArgs e)
        {
            X = 3;
            listBoxResultados.Items.Clear();
            for (int i = 1; i < ArregloDosDimensiones.GetLength(0); i++)
            {
                listBoxResultados.Items.Add(NotasParcial3[i]);
            }
        }        


        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            switch (X)
            {
                case 1:
                    textBoxPromedioxSeccion.Text = "" + PromedioParcial1.ToString();
                    break;
                case 2:
                    textBoxPromedioxSeccion.Text = "" + PromedioParcial2.ToString();
                    break;
                case 3:
                    textBoxPromedioxSeccion.Text = "" + PromedioParcial3.ToString();
                    break;
            }

            lstBoxPGS.Items.Clear();
            lstBoxPGS.Items.Add("Seccion A=" + promedioTotalSeccionA);
            lstBoxPGS.Items.Add("Seccion B=" + promedioTotalSeccionB);
            lstBoxPGS.Items.Add("Seccion C=" + promedioTotalSeccionC);


        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            switch (X)
            {
                case 1:
                    textBoxMax.Text = "" + NotasParcial1[60].ToString();
                    break;
                case 2:
                    textBoxMax.Text = "" + NotasParcial2[60].ToString();
                    break;
                case 3:
                    textBoxMax.Text = "" + NotasParcial3[60].ToString();
                    break;
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            switch (X)
            {
                case 1:
                    textBoxMin.Text = "" + NotasParcial1[1].ToString();
                    break;
                case 2:
                    textBoxMin.Text = "" + NotasParcial2[1].ToString();
                    break;
                case 3:
                    textBoxMin.Text = "" + NotasParcial3[1].ToString();
                    break;
            }

        }

        private void buttonSeccionA_Click(object sender, EventArgs e)
        {
            listBoxSección.Items.Clear();
            for (int i = 0; i < AlumnosSeccionA.GetLength(0); i++)
            {
                listBoxSección.Items.Add(AlumnosSeccionA[i, 0]);
            }
        }

        private void buttonPGS_Click(object sender, EventArgs e)
        {
            lstBoxPGS.Items.Clear();
            lstBoxPGS.Items.Add("Promedio Seccion 'A', parcial1= " + PGSAparcial1.ToString());
            lstBoxPGS.Items.Add( "Promedio Seccion 'B', parcial1= " + PGSBparcial1.ToString());
            lstBoxPGS.Items.Add("Promedio Seccion 'C', parcial1= " + PGSCparcial1.ToString());
            lstBoxPGS.Items.Add("Promedio Seccion 'A', parcial2= " + PGSAparcial2.ToString());
            lstBoxPGS.Items.Add("Promedio Seccion 'B', parcial2= " + PGSBparcial2.ToString());
            lstBoxPGS.Items.Add("Promedio Seccion 'C', parcial2= " + PGSCparcial2.ToString());
            lstBoxPGS.Items.Add("Promedio Seccion 'A', parcial3= " + PGSAparcial3.ToString());
            lstBoxPGS.Items.Add("Promedio Seccion 'B', parcial3= " + PGSBparcial3.ToString());
            lstBoxPGS.Items.Add("Promedio Seccion 'C', parcial2= " + PGSCparcial3.ToString());


        }

        private void buttonSeccionB_Click(object sender, EventArgs e)
        {
            listBoxSección.Items.Clear();
            for (int i = 0; i < AlumnosSeccionB.GetLength(0); i++)
            {
                listBoxSección.Items.Add(AlumnosSeccionB[i, 1]);
            }
        }

        private void buttonSeccionC_Click(object sender, EventArgs e)
        {
            listBoxSección.Items.Clear();
            for (int i = 0; i < AlumnosSeccionC.GetLength(0); i++)
            {
                listBoxSección.Items.Add(AlumnosSeccionC[i, 2]);
            }
        }

        private void buttonPGAlumnos_Click(object sender, EventArgs e)
        {
            lstBoxPGS.Items.Clear();
            for(int i = 0; i < promedio_Alumno.GetLength(0); i++)
            {
                //si es distinto a nulo se ejecuta el if y inserta en el listbox
                if (promedio_Alumno[i, 0] != null)
                {
                    lstBoxPGS.Items.Add(promedio_Alumno[i, 0] + " :" + promedio_Alumno[i, 1]);
                }
            }

        }

        private void btnSumaAlumno_Click(object sender, EventArgs e)
        {
            lstBoxPGS.Items.Clear();
            for(int i=0;i < sumaNotas_Alumnos.GetLength(0); i++)
            {
                //solo se imprimiran las posiciones que no tengan un valor nulo
                if (sumaNotas_Alumnos[i, 0] != null)
                {
                    lstBoxPGS.Items.Add(sumaNotas_Alumnos[i, 0] +  "Total:" + sumaNotas_Alumnos[i, 1]);
                }
            }
        }
    }
}
