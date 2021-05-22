using ProyectoFinal_WPF.CLASES;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoFinal_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private string nombreTexBox;
        //private string DPItexBox;
        //private string telefonoTexbox;
        DateTime? fecha ;
        DateTime? Fecha1;
        DateTime? Fecha2;
        string nombre;
        string telefono;
        string dpi;


        public int cantidadMesAño;
        public string[] alquilarx { get; set; }
        public string[] habitaciones { get; set; }
        public string[] num = new string[5] { "1", "2", "3", "4", "5" };
        public string opcionHabitaciones;
        public string opcionAlquilarx;
        public string nombreCons;
        public int CanHabitacionesCons = 0;
        public string tipoAlq;
        string nombreModificar;
        string opcionModificar;

        public MainWindow()
        {
            InitializeComponent();
            InitializerCombobox();
        }

        private void InitializerCombobox()
        {
            alquilarx = new string[] { "Mes", "Año" };
            habitaciones = new string[] { num[0], num[1], num[2], num[3], num[4] };
            DataContext = this;
        }

        private void ButtonGuardar_Click(object sender, RoutedEventArgs e)
        {
            nombre = TexBoxNombre.Text;
            dpi = TexBoxDPI.Text;
            telefono = TexBoxTelefono.Text;
            ClsConexion my = new ClsConexion();
            DataTable dt = my.consultaTablaDirecta(" insert into dbprogra.tb_proyectof values ('"+dpi+"','"+nombre+"','"+telefono+"','"+opcionHabitaciones+"','"+opcionAlquilarx+"','"+fecha.Value.ToString("yyyy/MM/dd")+"',"+cantidadMesAño+");");            
            TexBoxNombre.Clear();
            TexBoxDPI.Clear();
            TexBoxTelefono.Clear();
            

        }

        private void ButtonSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            fecha = SelecFecha.SelectedDate;
        }
        


        private void Chebox001_Checked(object sender, RoutedEventArgs e)
        {
            if (Chebox001.IsChecked == true)
            {
                Label001.Content = "001 RENTADO";
            }
            else
            {
                Label001.Content = "001 DISPONIBLE";
            }

        }

        private void Chebox002_Checked(object sender, RoutedEventArgs e)
        {
            if (Chebox002.IsChecked == true)
            {
                Label002.Content = "002 RENTADO";
            }
            else
            {
                Label002.Content = "002 DISPONIBLE";
            }

        }

        private void Chebox003_Checked(object sender, RoutedEventArgs e)
        {
            if (Chebox003.IsChecked == true)
            {
                Label003.Content = "003 RENTADO";
            }
            else
            {
                Label003.Content = "003 DISPONIBLE";
            }

        }

        private void Chebox004_Checked(object sender, RoutedEventArgs e)
        {
            if (Chebox004.IsChecked == true)
            {
                Label004.Content = "004 RENTADO";
            }
            else
            {
                Label004.Content = "004 DISPONIBLE";
            }
        }

        private void Chebox005_Checked(object sender, RoutedEventArgs e)
        {
            if (Chebox005.IsChecked == true)
            {
                Label005.Content = "005 RENTADO";
            }
            else
            {
                Label005.Content = "005 DISPONIBLE";
            }
        }
               

        private void ButtonSeleccionar1_Click(object sender, RoutedEventArgs e)
        {
            Fecha1 = DatePicker1.SelectedDate;
        }

        private void ButtonSeleccionar2_Click(object sender, RoutedEventArgs e)
        {
            Fecha2 = DatePicker2.SelectedDate;
        }

        private void ButtonDatosMostrar_Click(object sender, RoutedEventArgs e)
        {
            ClsConexion cn = new ClsConexion();
            DataTable dt = cn.consultaTablaDirecta("SELECT* FROM dbprogra.tb_proyectof where Fecha between '" + Fecha1.Value.ToString("yyyy/MM/dd") + "' and '" + Fecha2.Value.ToString("yyyy/MM/dd") + "'");
            ClsCargaArchivo ar = new ClsCargaArchivo(dt);

            string datoS = "";

            foreach (DataRow x in dt.Rows)
            {
                datoS += ($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]},{x[6]}\n");
            }

            ListDatos.ItemsSource = datoS;

        }

        private void ButtonBsxNombre_Click(object sender, RoutedEventArgs e)
        {
            string nombre = TexBoxNombreCons.Text;
            ClsConexion cn = new ClsConexion();
            DataTable dt = cn.consultaTablaDirecta("SELECT * FROM dbprogra.tb_proyectof where UPPER(Nombre) like ('%"+nombre+"%')");
            ClsCargaArchivo ar = new ClsCargaArchivo(dt);

            string datoS = "";

            foreach (DataRow x in dt.Rows)
            {
                datoS = ($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]},{x[6]}\n");
            }

            ListDatos.ItemsSource = datoS;

            TexBoxNombreCons.Clear();



        }
                       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClsConexion cn = new ClsConexion();
            nombreModificar = ModificarNom.Text;

            opcionModificar = Convert.ToString(ModificarAql.SelectedItem);
            DataTable dt = cn.consultaTablaDirecta("UPDATE dbprogra.tb_proyectof SET Tipo_Alquiler='" + opcionModificar + "' WHERE UPPER (Nombre) like('%"+nombreModificar+"%');");
            ModificarNom.Clear();
            ButtonAlqActual.Content = "ALQUILER ACTUAL";
        }

        private void ButtonAlqActual_Click(object sender, RoutedEventArgs e)
        {           
            

        }

        private void ButtonSelecAlq_Click(object sender, RoutedEventArgs e)
        {
            opcionAlquilarx = Convert.ToString(ComboboxAlquilarx .SelectedItem);
        }

        private void ButtonSelecHab_Click(object sender, RoutedEventArgs e)
        {
            cantidadMesAño = Convert.ToInt32(cantidadAlq.Text);
            opcionHabitaciones = Convert.ToString(ComboboxHabitaciones.SelectedItem);
            cantidadAlq.Clear();

        }
    }
}
