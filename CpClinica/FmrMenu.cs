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
    public partial class FmrMenu : Form
    {
        public FmrMenu(FmrInicio fmrInicio)
        {
            InitializeComponent();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            new FmrMedicos().ShowDialog();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            new FmrCita().ShowDialog();
        }
    }
}
