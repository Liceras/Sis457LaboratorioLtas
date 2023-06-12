using C1.Framework;
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
    public partial class FmrCita : Form
    {
        public FmrCita()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FmrCita_Load(object sender, EventArgs e)
        {

        }
        private bool validar()
        {
            bool esValido = true;
            erpUrgencia.SetError(txtUrgencia, "");

            if (string.IsNullOrEmpty(txtUrgencia.Text))
            {
                erpUrgencia.SetError(txtUrgencia, "El campo Urgencia es obligatorio");
                esValido = false;
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var citas = new Citas();
                citas.urgencia = txtUrgencia.Text;
                CitaCln.insertar(citas);

                MessageBox.Show("Cita guardada correctamente", "::: Clinica - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
