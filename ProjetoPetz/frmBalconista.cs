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
    public partial class frmBalconista : Form
    {
     

        public frmBalconista()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgendarS_Click(object sender, EventArgs e)
        {
            userAgendarS1.BringToFront();
           
        }

        private void btnManterS_Click(object sender, EventArgs e)
        {
            userManterS1.BringToFront(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userManterA1.BringToFront();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            userCliente1.BringToFront();
        }

        private void btnExibirD_Click(object sender, EventArgs e)
        {
            userExibirDisp1.BringToFront();
        }

        private void btnExecucaoServ_Click(object sender, EventArgs e)
        {

        }

        private void frmBalconista_Load(object sender, EventArgs e)
        {

        }
    }
}
