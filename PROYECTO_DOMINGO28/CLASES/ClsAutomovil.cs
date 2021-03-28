using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_DOMINGO28.CLASES
{
    class ClsAutomovil
    {
        public String Marca { get; }
        public int VelocidadMax { get; }
        private int VelocidadActual = 0;
        public bool Encendido = false;
        public String color { get; set; }

        public ClsAutomovil(string MarcaCarro, int VelocidadMaxCarro)
        {
            this.Marca = MarcaCarro;
            this.VelocidadMax = VelocidadMaxCarro;

        }

        public void EncenderMotor()
        {
            Encendido = true;            
        }

        public void AparagarMotor()
        {
            Encendido = false;
        }

        public void Acelerar()
        {
            VelocidadActual += 10;
        }

        public int  Frenar()
        {
            return VelocidadActual = 0;
        }

        public int  ObtenerVelocidad ()
        {
            return VelocidadActual;
        }

        public int ObtenerVelocidadMax()
        {
            return VelocidadMax;
        }


    }
}
