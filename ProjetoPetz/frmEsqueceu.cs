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
    public partial class frmEsqueceu : Form
    {
        public frmEsqueceu()
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

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            ClassRecuperar recuperar = new ClassRecuperar();

            lblDeuCerto.Text = "";
            lblErro.Text = "";
            recuperar.EmailEsquecido = txtEmailPerdido.Text;
            lblDeuCerto.Text = "Tentando enviar email...";
            if (recuperar.EsqueceuSenha() == false)
            {
                lblDeuCerto.Text = "";
                lblErro.Text = "Email não foi encontrado! Por favor, tente novamente.";
            }
            else
            {
                lblDeuCerto.Text = "Email enviado com sucesso! Tente logar novamente.";
                btnEnviarEmail.Hide();
            }

        }
        public void SemInternet()
        {
            lblErro.Text = "Não foi possível encontrar conexão com a internet!";
        }

    }
}

