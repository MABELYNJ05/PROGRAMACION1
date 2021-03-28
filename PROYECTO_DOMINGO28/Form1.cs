using PROYECTO_DOMINGO28.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DOMINGO28
{
    public partial class Form1 : Form
    {
        ClsAutomovil carrito;

        Random random = new Random();
        private string[] canciones;
        private bool encendido = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void CrearVehículoButton_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomovil("PICKUP, NISSAN", 180);
            carrito.color = "ROJO";
            MessageBox.Show($"Vehículo Creado\nMarca: {carrito.Marca}\nColor: {carrito.color}\nVelocidad Maxima: {carrito.VelocidadMax}km/h");
            pictureBox1.Image = Properties.Resources.PICKUPNISSAN;
        }

        private void EncenderButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Encender;
            if (encendido == false)
            {
                EncenderButton.Text = "APAGAR VEHÍCULO";
                EncenderButton.BackColor = Color.Red;
                carrito.EncenderMotor();
                encendido = true;
            }else if (encendido == true)
            {
                EncenderButton.Text = "ENCENDER VEHÍCULO";
                EncenderButton.BackColor = Color.Green;
                carrito.AparagarMotor();
                encendido = false;
                label1.Text = carrito.Frenar().ToString() + " km/h";
            }
             
        }

        private void AcelerarButton_Click(object sender, EventArgs e)
        {
            if (encendido== true)
            {
                pictureBox1.Image = Properties.Resources.VELOCIMETRO;

                carrito.Acelerar();
                if (carrito.ObtenerVelocidad() <= carrito.ObtenerVelocidadMax()) 
                {
                    label1.Text = carrito.ObtenerVelocidad().ToString() + " km/h";

                } 
                else if (carrito.ObtenerVelocidad() >= carrito.ObtenerVelocidadMax())
                {
                    MessageBox.Show("Alzancó su velocidad máxima");

                }

            }else
            {
                MessageBox.Show("Encienda el Vehículo");
            }

        }

        private void FrenarButton_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Properties.Resources.FRENAR;
            label1.Text = carrito.Frenar().ToString() + " km/h";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (encendido == true)
            {
                pictureBox1.Image = Properties.Resources.parabrisas;

            }
            else
            {
                MessageBox.Show("Encienda el Vehículo");

            }
        }       

        private void Play_Click(object sender, EventArgs e)
        {
            if (encendido == true)
            {
                canciones = Directory.GetFiles(@"C:\Users\cmabe\Music\music", "*.mp3");
                REPRODUCTOR.URL = canciones[0];
            }else
            {
                MessageBox.Show("Encienda el Vehículo");
            }

        }

        private void Aleatorio_Click(object sender, EventArgs e)
        {
            int numero = random.Next(1, canciones.Length);
            REPRODUCTOR.URL = canciones[numero];
        }

        private void Pausa_Click(object sender, EventArgs e)
        {
            REPRODUCTOR.Ctlcontrols.pause();
        }

        private void Deterner_Click(object sender, EventArgs e)
        {
            REPRODUCTOR.Ctlcontrols.stop();
        }
    }
}
