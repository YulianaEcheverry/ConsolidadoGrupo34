using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2JessicaCatherineLozano
{
    public partial class IngresoDatos : Form
    {
        public IngresoDatos()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbInstrumento.SelectedItem.ToString())
            {
                case "Piano":
                    txtCostoPorClase.Text = 100000.ToString();
                    break;

                case "Guitarra":
                    txtCostoPorClase.Text = 80000.ToString();
                    break;

                case "Violín":
                    txtCostoPorClase.Text = 90000.ToString();
                    break;

                case "Batería":
                    txtCostoPorClase.Text = 85000.ToString();
                    break;

                case "Canto":
                    txtCostoPorClase.Text = 95000.ToString();
                    break;

                default:
                    txtCostoPorClase.Text = 0.ToString();
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdentificacion.Focus(); 
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCompleto.Focus();  
                return;
            }
            if (cmbInstrumento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un instrumento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbInstrumento.Focus();  
                return;
            }

            if (!int.TryParse(txtNumeroClases.Text, out int numeroDeClases) || numeroDeClases <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido de clases.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroClases.Focus(); 
                return;
            }
            
            if (!decimal.TryParse(txtCostoPorClase.Text, out decimal costoClase) || costoClase <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el costo por clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostoPorClase.Focus();  
                return;
            }
            GestionEstudiantes estudiante = new GestionEstudiantes();
            estudiante.Identificacion = txtIdentificacion.Text;
            estudiante.NombreCompleto = txtNombreCompleto.Text;

            if (rbtnMasculino.Checked)
            {
                estudiante.Genero = "Masculino";
            }
            else if (rbtnFemenino.Checked)
            {
                estudiante.Genero = "Femenino";
            }

            estudiante.Instrumento = cmbInstrumento.SelectedItem.ToString();
            estudiante.NumeroClases = Convert.ToInt32(txtNumeroClases.Text);
            estudiante.CostoPorClase = Convert.ToDecimal(txtCostoPorClase.Text);
            estudiante.FechaRegistro = dtpFechaRegistro.Value;

            MessageBox.Show("Registro guardado correctamente", "Información", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro que desea salir de la aplicación", "Confirmación de salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            GestionEstudiantes estudiante = new GestionEstudiantes();
            estudiante.NumeroClases = Convert.ToInt32(txtNumeroClases.Text);
            estudiante.CostoPorClase = Convert.ToDecimal(txtCostoPorClase.Text);

            decimal costoTotal = estudiante.CalcularCostoTotal();

            Reporte reporteForm = new Reporte();
            reporteForm.txtIdentificacion.Text = txtIdentificacion.Text;
            reporteForm.txtNombreCompleto.Text = txtNombreCompleto.Text;

            if (rbtnMasculino.Checked)
            {
                reporteForm.rbtnMasculino.Checked = true;
            }
            else if (rbtnFemenino.Checked)
            {
                reporteForm.rbtnFemenino.Checked = true;
            }

            reporteForm.cmbActividad.Text = cmbInstrumento.SelectedItem.ToString();
            reporteForm.txtNumeroClases.Text = txtNumeroClases.Text;
            reporteForm.txtCostoPorClase.Text = txtCostoPorClase.Text;
            reporteForm.txtCostoTotal.Text = costoTotal.ToString();
            reporteForm.ShowDialog();
        }

        private void txtNumeroClases_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroClases.Text, out _))
            {
                MessageBox.Show("Solo se permite el ingreso de números en 'Número de Clases'.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroClases.Clear(); 
            }

        }

        private void IngresoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
