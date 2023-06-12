using CadClinica;
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
    public partial class FmrMedicos : Form
    {
        public FmrMedicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FmrMedicos_Load(object sender, EventArgs e)
        {

        }
        public static List<Medico> listar()
        {
            using (var contexto = new ClinicaEntities())
            {
                return contexto.Medico.Where(x => x.registroActivo).ToList();
            }
        }
    }
}
