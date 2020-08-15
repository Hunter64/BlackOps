using Models;
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
using System.Windows.Threading;

namespace BlackOps.Interfaz2
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        //private DispatcherTimer dispatcherTimer = null;

        public Create()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data()
            {
                Abono = Abono.Text,
                Cargo = Cargo.Text,
                Concepto = Concepto.Text,
                Cuenta = Cuenta.Text,
                Fecha = Fecha.DisplayDate,
                Final = Final.Text,
                Inicial = Inicial.Text
            };
        }

        private void Inicial_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
