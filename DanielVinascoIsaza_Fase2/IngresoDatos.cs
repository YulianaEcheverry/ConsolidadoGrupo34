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
    public partial class IngresoDatos : Form
    {
        public IngresoDatos()
        {
            InitializeComponent();
        }
        
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            // Verificar que los campos "Identificación" y "Nombre" no estén vacíos
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdentificacion.Focus();  // Lleva el foco al campo de identificación
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();  // Lleva el foco al campo de nombre
                return;
            }

            // Verificar que el instrumento esté seleccionado
            if (cmbInstrumento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un instrumento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbInstrumento.Focus();  // Lleva el foco al campo de selección de instrumento
                return;
            }

            // Verificar que el número de clases sea un valor válido
            if (!int.TryParse(txtNumeroDeClases.Text, out int numeroDeClases) || numeroDeClases <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido de clases.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroDeClases.Focus();  // Lleva el foco al campo del número de clases
                return;
            }

            // Verificar que el costo por clase sea un valor válido
            if (!decimal.TryParse(txtCostoClase.Text, out decimal costoClase) || costoClase <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el costo por clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostoClase.Focus();  // Lleva el foco al campo de costo por clase
                return;
            }

            // Si todas las validaciones pasan, se procede a guardar la información
            GestionEstudiantes estudiante = new GestionEstudiantes();
            estudiante.Identicacion = txtIdentificacion.Text;
            estudiante.Nombre = txtNombre.Text;

            if (rbtnMasculino.Checked)
            {
                estudiante.Genero = "Masculino";
            }
            else if (rbtnFemenino.Checked)
            {
                estudiante.Genero = "Femenino";
            }

            estudiante.Instrumento = cmbInstrumento.SelectedItem.ToString();
            estudiante.NumeroDeClases = numeroDeClases;
            estudiante.CostoClase = costoClase;
            estudiante.FechaRegistro = dateTimePicker1.Value;

            // Mostrar un mensaje de confirmación de guardado
            MessageBox.Show("Su registro se ha guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            // mostrar un cuadro de dialogo para la confirmación 
            DialogResult resutado = MessageBox.Show("Esta seguro que desea salir de la aplicación", " confirmación de salida ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resutado == DialogResult.Yes)
                {
                   //Application.Exit();

                   this.Close();
                }
            

        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            GestionEstudiantes estudiante = new GestionEstudiantes();

            // Convertir el número de clases
            if (int.TryParse(txtNumeroDeClases.Text, out int numeroDeClases))
            {
                estudiante.NumeroDeClases = numeroDeClases;
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para el número de clases.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si hay error
            }

            // Convertir el costo de la clase a decimal
            if (decimal.TryParse(txtCostoClase.Text, out decimal costoClase))
            {
                estudiante.CostoClase = costoClase;
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para el costo de la clase.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si hay error
            }

            // Calcular el costo total
            decimal CostoTotal = estudiante.CalcularaCostoTotal();

            // Crear una instancia del formulario de reporte
            Reporte reporteForm = new Reporte();

            // Pasar los datos del estudiante al formulario de reporte
            reporteForm.txtIdentificacion.Text = txtIdentificacion.Text;
            reporteForm.txtNombre.Text = txtNombre.Text;

            // Género
            if (rbtnMasculino.Checked)
            {
                reporteForm.rbtnMasculino.Checked = true;
            }
            else if (rbtnFemenino.Checked)
            {
                reporteForm.rbtnFemenino.Checked = true;
            }

            // Instrumento y datos
            reporteForm.cmbInstrumento.Text = cmbInstrumento.SelectedItem.ToString();
            reporteForm.txtNumeroDeClases.Text = txtNumeroDeClases.Text;
            reporteForm.txtCostoClase.Text = txtCostoClase.Text;
            reporteForm.txtCostoTotal.Text = CostoTotal.ToString();

            // Mostrar el formulario de reporte
            reporteForm.ShowDialog();

            // cerrar el formulario de inicio si es necesario 
            this.Hide();
        }

        private void txtNumeroDeClases_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDeClases.Text, out _))
            {
                MessageBox.Show("Ingrese solo números en el campo 'Número de Clases'.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroDeClases.Clear(); // Limpiar el campo si el valor es incorrecto
            }

        }

        private void txtCostoClase_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbInstrumento_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            switch (cmbInstrumento.SelectedItem.ToString())
            {
                case "Piano":
                    txtCostoClase.Text = 100000.ToString();
                    break;

                case "Guitarra":
                    txtCostoClase.Text = 80000.ToString();
                    break;

                case "Violin":
                    txtCostoClase.Text = 90000.ToString();
                    break;

                case "Batería":
                    txtCostoClase.Text = 85000.ToString();
                    break;

                case "Canto":
                    txtCostoClase.Text = 95000.ToString();
                    break;

                default:
                    txtCostoClase.Text = 0.ToString();
                    break;
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
