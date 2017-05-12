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
//-------------------------------------
using NHJ.Wpf_DataContext_ClasePersonas;

namespace Wpf_DataContext_ClasePersonas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona unaPersona = null;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();

            // Poner el contexto de datos al Grid
            unaPersona = new Persona();
            grdDatos.DataContext = unaPersona;
        }

        private void btnOtraPersona_Click(object sender, RoutedEventArgs e)
        {
            unaPersona = new ListaPersonas()[rnd.Next(new ListaPersonas().Count)];
            grdDatos.DataContext = unaPersona;
        }

        private void btnCambiaNombre_Click(object sender, RoutedEventArgs e)
        {
            unaPersona.Nombre = "Eliseo";
        }
    }
}
