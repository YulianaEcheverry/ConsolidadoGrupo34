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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            IngresarDatos ingresoForm = new IngresarDatos();

            this.Close();

            ingresoForm.Show();
        }

        private void txtCostoTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
