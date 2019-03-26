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
    public partial class frmLogin : Form
    {
        public frmLogin()
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmBalconista balconista = new frmBalconista();

            balconista.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdministrador administrador = new FrmAdministrador();
            administrador.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ClassFuncionario funcionario = new ClassFuncionario();

            funcionario.email = txtLogin.Text;
            funcionario.senha = txtSenha.Text;

            //Preenche a tabela com todos os dados vindos do select de 
            //realizar login
            DataTable dt = funcionario.RealizarLogin();


            //Como saber se foram retornados registros do select
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("     Usuário não existe!");

            }
            else
            {
                // Usar os dados desta tabela
                string nome = dt.Rows[0]["nome"].ToString();
                string codUser = dt.Rows[0]["codFuncionario"].ToString();
                string tipoUsuario = dt.Rows[0]["codTipo"].ToString();

                txtLogin.Text = "";
                txtSenha.Text = "";

                FrmAdministrador admnistrador = new FrmAdministrador();
                frmBalconista balconista = new frmBalconista();

                if (tipoUsuario == "1")
                {
                    admnistrador.Show();
                }
                else if (tipoUsuario == "2")
                {
                    balconista.Show();
                }else if(tipoUsuario == "3"){
                    MessageBox.Show("Olá veterinário, infelizmente você não tem permissão para acessar.");
                }

            }
        }

        private void btnEsqueceu_Click(object sender, EventArgs e)
        {
            
        }

        private void userRecuperarSenha1_Load(object sender, EventArgs e)
        {

        }

        private void btnEsqueceu_Click_1(object sender, EventArgs e)
        {
            frmEsqueceu esqueceu = new frmEsqueceu();
            esqueceu.Show();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '•';
        }
    }
}
