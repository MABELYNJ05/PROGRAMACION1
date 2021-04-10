using Arreglos_POO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_POO
{
    public partial class Form1 : Form
    {
        private string[] ArregloNombres;
        private string[]NotasParcialTemporal;
        private string[] NotasParcial1;
        private string[] Nombres;
        private string[] NotasParcial2;
        private string[] NotasParcial3;
        private string[] Datos;
        string[] resultado;
        private int X = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonCargar_Click(object sender, EventArgs e)
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
            try
            {
                ClsArchivo objarchiv = new ClsArchivo();

                Datos = objarchiv.cargarDatos(ArregloNombres);
                ClsArreglos ObjArreglos = new ClsArreglos(Datos);
                resultado = ObjArreglos.MetodoBurbuja();
                ManejoDatos objmanejoDatos = new ManejoDatos();
                Nombres = objmanejoDatos.columnas(resultado, 0);
                NotasParcial1 = objmanejoDatos.columnas(resultado, 1);
                NotasParcial2 = objmanejoDatos.columnas(resultado, 2);
                NotasParcial3 = objmanejoDatos.columnas(resultado, 3);
                for (int indice = 0; indice < Nombres.Length; indice++)
                {
                    listBoxResutado.Items.Add(Nombres[indice]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Necesita carga un archivo plano para poder ejecutar el programa."+ex);
            }                         
            

        }
      

        private void buttonParcial1_Click(object sender, EventArgs e)
        {
            X = 1;
            listBoxNotas.Items.Clear();
            foreach (string linea in NotasParcial1)
            {
               
                listBoxNotas.Items.Add(linea);
            }

        }

        private void buttonSumaNotas_Click(object sender, EventArgs e)
        {
            ManejoDatos objmanejoDatos = new ManejoDatos();
            switch (X)
            {
                case 1:
                    textBoxSumaNotas.Text =(objmanejoDatos.sumarNotas(NotasParcial1)).ToString();
                    break;
                case 2:
                    textBoxSumaNotas.Text = (objmanejoDatos.sumarNotas(NotasParcial2)).ToString();
                    break;
                case 3:
                    textBoxSumaNotas.Text = (objmanejoDatos.sumarNotas(NotasParcial3)).ToString(); 
                    break;

            }
        }

        private void buttonParcial2_Click(object sender, EventArgs e)
        {
            X = 2;
            listBoxNotas.Items.Clear();
            foreach (string linea in NotasParcial2)
            {

                listBoxNotas.Items.Add(linea);
            }

        }

        private void buttonParcial3_Click(object sender, EventArgs e)
        {
            X = 3;
            listBoxNotas.Items.Clear();
            foreach (string linea in NotasParcial3)
            {

                listBoxNotas.Items.Add(linea);
            }

        }

        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            ManejoDatos objmanejoDatos = new ManejoDatos();
            switch (X)
            {
                case 1:
                    textBoxPromedio.Text = (objmanejoDatos.Promedio(NotasParcial1)).ToString();
                    break;
                case 2:
                    textBoxPromedio.Text = (objmanejoDatos.Promedio(NotasParcial2)).ToString();
                    break;
                case 3:
                    textBoxPromedio.Text= (objmanejoDatos.Promedio(NotasParcial3)).ToString();
                    break;

            }
        }

        private void buttonNotaMax_Click(object sender, EventArgs e)
        {

            ManejoDatos objmanejoDatos = new ManejoDatos();
            switch (X)
            {
                case 1:
                    textBoxNotaMax.Text = (objmanejoDatos.numeroMayor(NotasParcial1)).ToString();
                    break;
                case 2:
                    textBoxNotaMax.Text = (objmanejoDatos.numeroMayor(NotasParcial2)).ToString();
                    break;
                case 3:
                    textBoxNotaMax.Text = (objmanejoDatos.numeroMayor(NotasParcial3)).ToString();
                    break;

            }

        }

        private void buttonNotaMin_Click(object sender, EventArgs e)
        {
            ManejoDatos objmanejoDatos = new ManejoDatos();
            switch (X)
            {
                case 1:
                    textBoxNotaMin.Text = (objmanejoDatos.numeroMenor(NotasParcial1)).ToString();
                    break;
                case 2:
                    textBoxNotaMin.Text = (objmanejoDatos.numeroMenor(NotasParcial2)).ToString();
                    break;
                case 3:
                    textBoxNotaMin.Text = (objmanejoDatos.numeroMenor(NotasParcial3)).ToString();
                    break;

            }
        }
    }
}
