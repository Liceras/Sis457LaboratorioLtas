using CadClinica;
using ClnClinica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpClinica
{
    public partial class FmrNuevoPaciente : Form
    {
        bool esNuevo = false;
        public FmrNuevoPaciente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private bool validar()
        {
            bool esValido = true;
            erpDNI.SetError(txtDNI, "");
            erpNombres.SetError(txtNombres, "");
            erpApellidos.SetError(txtApellidos, "");
            erpDireccion.SetError(txtDireccion, "");
            erpTelefono.SetError(txtTelefono, "");

            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                erpDNI.SetError(txtDNI, "El campo DNI es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                erpNombres.SetError(txtNombres, "El campo Nombres es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                erpApellidos.SetError(txtApellidos, "El campo Apellidos  es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                erpDireccion.SetError(txtDireccion, "El campo Direccion es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                erpTelefono.SetError(txtTelefono, "El campo Telefono debe ser mayor a 0");
                esValido = false;
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var paciente = new Paciente();
                paciente.DNI = (int?)Convert.ToInt64(txtDNI.Text);
                paciente.nombres = txtNombres.Text;
                paciente.apellidos = txtApellidos.Text;
                paciente.direccion = txtDireccion.Text;
                paciente.telefono = (int?)Convert.ToInt64(txtTelefono.Text);
                PacienteCln.insertar(paciente);

                MessageBox.Show("Paciente guardado correctamente", "::: Clinica - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FmrNuevoPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
