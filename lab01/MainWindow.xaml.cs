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

namespace lab01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string usuario = UsernameTextBox.Text;
            string contra = PasswordBox.Password;

            if(usuario == "Renzo" && contra =="1234")
            {
                ResultLabel.Content = "Inicio de sesion exitoso";


                Window1 window = new Window1();

                this.Close();
                window.Show();
            }
            else
            {
                ResultLabel.Content = "Credenciales Incorrectas.";
            }
        }

        
    }
}
