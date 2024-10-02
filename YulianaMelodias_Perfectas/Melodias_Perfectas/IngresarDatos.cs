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
    public partial class IngresarDatos : Form
    {
        public IngresarDatos()
        {
            InitializeComponent();
        }

        private void IngresarDatos_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbInstrumento.SelectedItem.ToString())
            {
                case "Piano":
                    txtCostoClase.Text = "100000";
                    break;
                case "Guitarra":
                    txtCostoClase.Text = "80000";
                    break;
                case "Violin":
                    txtCostoClase.Text = "90000";
                    break;
                case "Bateria":
                    txtCostoClase.Text = "85000";
                    break;
                case "Canto":
                    txtCostoClase.Text = "95000";
                    break;

                default:
                    txtCostoClase.Text = "0";
                    break;


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GestionEstudiantes estudiantes = new GestionEstudiantes();
            estudiantes.Id = txtId.Text;
            estudiantes.NombreCompleto = txtNombreCompleto.Text;

            if (rbtnMasculino.Checked)
            {
                estudiantes.Genero = "Masculino";

            }
            else if (rbtnFemenino.Checked)
            {
                estudiantes.Genero = "Femenino";

            }
            estudiantes.Instrumento = cmbInstrumento.SelectedItem.ToString();

            estudiantes.NumeroClase = Convert.ToInt32(txtNumeroClases.Text);

            estudiantes.CostoClase = Convert.ToInt32(txtCostoClase.Text);

            estudiantes.FechaIngreso = dtpFechaIngreso.Value;

            MessageBox.Show("Registro guardado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            GestionEstudiantes estudiantes = new GestionEstudiantes();
            estudiantes.NumeroClase = Convert.ToInt32(txtNumeroClases.Text);
            estudiantes.CostoClase = Convert.ToInt32(txtCostoClase.Text);

            decimal costoTotal = estudiantes.CalcularCostoTotal();

            Reporte reporteform = new Reporte();

            reporteform.txtId.Text = txtId.Text;
            reporteform.txtNombreCompleto.Text = txtNombreCompleto.Text;

            if (rbtnMasculino.Checked)
            {
                reporteform.rbtnMasculino.Checked = true;

            }
            else if (rbtnFemenino.Checked)
            {
                reporteform.rbtnFemenino.Checked = true;
            }

            reporteform.cmbInstrumento.Text = cmbInstrumento.SelectedItem.ToString();
            reporteform.txtNumeroClases.Text = txtNumeroClases.Text;
            reporteform.txtCostoClase.Text = txtCostoClase.Text;
            reporteform.txtCostoTotal.Text = costoTotal.ToString();


            reporteform.ShowDialog();
            this.Hide();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea salir de la aplicacion", "Confirmacion de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)


                this.Close();
        }

        private void txtCostoClase_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroClases_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
