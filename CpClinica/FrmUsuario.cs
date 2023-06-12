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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");
            erpUsuarioRegistro.SetError(txtUsuarioRegistro, "");

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpClave.SetError(txtClave, "El campo Clave es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtUsuarioRegistro.Text))
            {
                erpUsuarioRegistro.SetError(txtUsuarioRegistro, "El campo Usuario Registro es obligatorio");
                esValido = false;
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = new Usuario();
                usuario.usuario1 = txtUsuario.Text;
                usuario.clave = txtClave.Text;
                usuario.usuarioRegistro = txtUsuarioRegistro.Text;
                usuario.fechaRegistro = DateTime.Now;
                usuario.id_Paciente = new Paciente().id;
                UsuarioCln.insertar(usuario);

                MessageBox.Show("Usuario guardado correctamente", "::: Clinica - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
