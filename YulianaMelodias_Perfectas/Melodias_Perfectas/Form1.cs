using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melodias_Perfectas
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


        private void btnInicio_Click(object sender, EventArgs e)
        {
            string passwordCorrecta = "123";

            if (txtInicio.Text == passwordCorrecta)
            {
                MessageBox.Show("Contraseña Correcta, Bienvenido....", "acceso concedido",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                IngresarDatos ingreso = new IngresarDatos();
                ingreso.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("contraseña incorrecta, intenta nuevamente.....", "error de acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtInicio.Clear();
                txtInicio.Focus();
            }

        }

        private void txtInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

    }
}