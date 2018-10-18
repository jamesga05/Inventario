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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = "James";
            string clave = "123";

            if(textBox1.Text=="James"&&textBox2.Text=="123")
                {
                Form2 formulario = new Form2();
                formulario.Show();
                textBox1.Clear();
                textBox2.Clear();

            }
            else
            {
                MessageBox.Show("Datos incorrectos, intenta otra vez ");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
