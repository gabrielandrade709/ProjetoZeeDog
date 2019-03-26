using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoZeeDog
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnManterF_Click(object sender, EventArgs e)
        {
            userFuncionario1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userExecucao1.BringToFront();
        }

        private void btnEmitirR_Click(object sender, EventArgs e)
        {
            userEmitirR1.BringToFront();
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
