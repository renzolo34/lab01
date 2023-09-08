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
using System.Windows.Shapes;

namespace lab01
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private List<Camion> camiones = new List<Camion>();
        public Window1()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void IngresosOpe_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SalidasOpe_Click(object sender, RoutedEventArgs e)
        {
            ConductoresGrid.Visibility = Visibility.Collapsed;
            MatenimienoGrid.Visibility = Visibility.Collapsed;
            OperacionesGrid.Visibility = Visibility.Visible;
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            OperacionesGrid.Visibility = Visibility.Collapsed;
            MatenimienoGrid.Visibility = Visibility.Collapsed;
            ListaCamionesGrid.Visibility = Visibility.Visible;
        }

        private void Transportistas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {

            OperacionesGrid.Visibility = Visibility.Collapsed;
            ListaCamionesGrid.Visibility = Visibility.Collapsed;
            ConductoresGrid.Visibility = Visibility.Collapsed;
            MatenimienoGrid.Visibility = Visibility.Visible;
        }

        private void Producto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cargas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IngresosReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SalidasReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegistarCamion_Click(object sender, RoutedEventArgs e)
        {
            string pesoMaximo = PesoMaximoTextBox.Text;
            string placa = PlacaTextBox.Text;
            string pesoVacio = PesoVacioTextBox.Text;

            // Crear un nuevo objeto Camion
            Camion nuevoCamion = new Camion
            {
                PesoMaximo = pesoMaximo,
                Placa = placa,
                PesoVacio = pesoVacio
            };

            // Agregar el camión a la lista
            camiones.Add(nuevoCamion);

            // Mostrar la lista actualizada en el ListBox
            Actualziar_Click();
        }

        private void Actualziar_Click()
        {
            // Limpiar el ListBox
            ListaCamiones.Items.Clear();

            // Agregar los camiones a la lista
            foreach (Camion camion in camiones)
            {
                ListaCamiones.Items.Add($"Placa: {camion.Placa}, Peso Máximo: {camion.PesoMaximo}, Peso Vacío: {camion.PesoVacio}");
            }
        }

        
    }
}
