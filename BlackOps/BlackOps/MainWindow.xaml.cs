using Ops;
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

namespace BlackOps
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

        private void ButtonIngresoOnClick(object sender, RoutedEventArgs e)
        {
            var user = TextUsuario.Text;
            var pass = TextPassword.Password;

            if (validar_datos_entrada(user, pass))
            {
                Class1 class1 = new Class1();
                bool is_conected = class1.Conectar();
                if (is_conected)
                {
                    MessageBox.Show("Conectado a la base");
                }
                else
                {
                    MessageBox.Show("Error de conexión");
                }
            }
            else
            {
                MessageBox.Show("Error al intentar inciar", "BlackOps", MessageBoxButton.OK, MessageBoxImage.Warning);
                TextUsuario.Text = string.Empty;
                TextPassword.Password = string.Empty;
            }

        }

        private bool validar_datos_entrada(string user, string pass)
        {
            return user == "kilo" && pass == "lima64";
        }
    }
}
