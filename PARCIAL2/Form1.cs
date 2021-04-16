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
        private string[,] AlumnosSeccionA;
        private string[,] AlumnosSeccionB;
        private string[,] AlumnosSeccionC;

        private int Promedio1;
        private int Promedio2;
        private int Promedio3;
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
            ofd.InitialDirectory = @"C:\Users\cmabe\OneDrive\Escritorio\C# Arreglos";
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

            //ClsPromedios ObjPromedios = new ClsPromedios();
            //AlumnosSeccionA = ObjPromedios.Clasificar_Alumnos(ArregloDosDimensiones, "A");
            //AlumnosSeccionB = ObjPromedios.Clasificar_Alumnos(ArregloDosDimensiones, "B");
            //AlumnosSeccionC = ObjPromedios.Clasificar_Alumnos(ArregloDosDimensiones, "C");


            ClsArregloNotas ObjArregloNotas = new ClsArregloNotas();
            NotasParcial1 = ObjArregloNotas.MetodoBurbujaEnteros(ArregloDosDimensiones, 2);
            NotasParcial2 = ObjArregloNotas.MetodoBurbujaEnteros(ArregloDosDimensiones, 3);
            NotasParcial3 = ObjArregloNotas.MetodoBurbujaEnteros(ArregloDosDimensiones, 4);
            Promedio1 = ObjArregloNotas.promedios(NotasParcial1);
            Promedio2 = ObjArregloNotas.promedios(NotasParcial2);
            Promedio3 = ObjArregloNotas.promedios(NotasParcial3);


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
            for (int i = 0; i < ArregloDosDimensiones.GetLength(0); i++)
            {
                listBoxResultados.Items.Add(NotasParcial3[i]);
            }
        }        


        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            switch (X)
            {
                case 1:
                    textBoxPromedio.Text = "" + Promedio1.ToString();
                    break;
                case 2:
                    textBoxPromedio.Text = "" + Promedio2.ToString();
                    break;
                case 3:
                    textBoxPromedio.Text = "" + Promedio3.ToString();
                    break;
            }


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
            for (int i = 1; i < AlumnosSeccionA.GetLength(0); i++)
            {
                listBoxSección.Items.Add(AlumnosSeccionA[i, 0]);
            }
        }
    }
}
