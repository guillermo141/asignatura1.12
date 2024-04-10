using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asignatura1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == string.Empty))
            {
                MessageBox.Show("Ingresa el nombre de la asignatura");
            }
            else
            {
                int codigo = int.Parse(textBox3.Text);
                string nombre = (textBox2.Text);
                asignatura asignatura1 = new asignatura(nombre, codigo);
                textBox1.Text = asignatura1.Mostrardato();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == string.Empty))
            {
                MessageBox.Show("nitas teoricas");
            }
            else
            {
               
            }
        }
    }
}
