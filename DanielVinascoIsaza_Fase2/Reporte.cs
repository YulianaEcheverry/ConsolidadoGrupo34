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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void txtCostoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // crear una nueva instancia del formulario Ingresar Datos 
            IngresoDatos ingresoForm = new IngresoDatos();

            // Cerrar el formulario actual de reporte 
            this.Close();

            //mostrar de nuevo formulario de ingreso de datos en blanco 
            ingresoForm.Show(); 
        }
    }
}
