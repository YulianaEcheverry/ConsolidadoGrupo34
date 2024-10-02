using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielVinascoIsaza_Fase2
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string contraseñaCorrecta = "123";

            if (txtInicio.Text == contraseñaCorrecta)
            {
               // MessageBox.Show(" Contraseña correcta, bienvenido al sistema" , "Acceso concedido",
                  //  MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Se abre la siguiente ventana 

                IngresoDatos ingreso = new IngresoDatos();
                ingreso.Show();

                // cerrar el formulario de inicio si es necesario 
                this.Hide();

            }
            else
            {
                MessageBox.Show("Contraseña incorrecta, intente otra vez", " Error de acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos el campo de texto para volver a ingresar la contraseña
                txtInicio.Clear();
                txtInicio.Focus();
            }

        }

        private void txtInicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
