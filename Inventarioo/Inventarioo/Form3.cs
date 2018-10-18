using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarioo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void base_de_datosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.base_de_datosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database11DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database11DataSet.Base_de_datos' Puede moverla o quitarla según sea necesario.
            this.base_de_datosTableAdapter.Fill(this.database11DataSet.Base_de_datos);

        }

        private void codigo_del_productoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
