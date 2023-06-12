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
    public partial class FmrPaciente : Form
    {
        //bool esNuevo = false;
        public FmrPaciente()
        {
            InitializeComponent();
        }

        private void FmrPaciente_Load(object sender, EventArgs e)
        {
            Size = new Size(1305, 594);
        }

        private void lblPaciente_Click(object sender, EventArgs e)
        {

        }

        private void lblParametro_Click(object sender, EventArgs e)
        {

        }
        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            new FmrNuevoPaciente().ShowDialog();
        }

        private void lblParametro_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
