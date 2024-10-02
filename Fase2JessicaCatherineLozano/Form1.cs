using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2JessicaCatherineLozano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string contraseñaCorrecta = "123";
            if (txtInicio.Text == contraseñaCorrecta)
            {
               MessageBox.Show("Contraseña correcta, Bienvevido...", "Acceso concedido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                IngresoDatos ingreso = new IngresoDatos();
                ingreso.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("Contraseña incorrecta, intente nuevamente...", "Error de acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInicio.Clear();
                txtInicio.Focus();
            }
        }

    }
}
