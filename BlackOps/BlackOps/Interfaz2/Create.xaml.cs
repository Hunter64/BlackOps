using Models;
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
                Id = Guid.NewGuid(),
                Abono = Convert.ToDecimal(Abono.Text),
                Cargo = Convert.ToDecimal(Cargo.Text),
                Concepto = Concepto.Text,
                Cuenta = Cuenta.Text,
                Fecha = DateTime.Now, //Fecha.DisplayDate,
                Final = Convert.ToDecimal(Final.Text),
                Inicial = Convert.ToDecimal(Inicial.Text)
            };

            Class1 class1 = new Class1();
            var result = class1.InsertAsync(data.Id, data);
            MessageBox.Show("Data " + result);
        }
    }
}
