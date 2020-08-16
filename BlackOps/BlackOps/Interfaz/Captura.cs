using Models;
using Ops;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackOps.Interfaz
{
    public partial class Captura : Form
    {
        public Captura()
        {
            InitializeComponent();
        }

        public void Start()
        {
            _ = Form.ActiveForm;
        }

        private async void save_Click(object sender, EventArgs e)
        {
            //var data = new Data
            //{
            //    Cuenta = cuenta_text_box.Text,
            //    Concepto = concepto_tex_box.Text,
            //    Fecha = fecha_datetime_picker.Value,
            //    Inicial = inicial_text_box.Text,
            //    Cargo = cargo_text_box.Text,
            //    Abono = abono_text_box.Text,
            //    Final = final_text_box .Text
            //};

            //Class1 class1 = new Class1();
            //var result = class1.InsertAsync(cuenta_text_box.Text, data);
            //MessageBox.Show("Data " + result.Result.Concepto);
        }

        private void Captura_Load(object sender, EventArgs e)
        {

        }
    }
}
