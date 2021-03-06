using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PARCIALPROGRAFINAL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string RESULTADOUSUARIO = (resultadoUsuario.Text);
            RESULTADOUSUARIO = RESULTADOUSUARIO.Remove(RESULTADOUSUARIO.Length - 1);
           

            int RESULTADONUMERO = Convert.ToInt32(RESULTADOUSUARIO);
            RESULTADONUMERO = RESULTADONUMERO - 4;

           
            resultadoNumero.Text=RESULTADONUMERO.ToString();


        }
    }
}
