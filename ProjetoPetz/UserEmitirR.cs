using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoZeeDog
{
    public partial class UserEmitirR : UserControl
    {
        ClassRelatorio relatorio = new ClassRelatorio();
        string dia = "";
        public UserEmitirR()
        {
            InitializeComponent();
        }

        private void btnBucsarPD_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            mskDiaBuscado.Hide();
            lblAlgum.Text = "Donos e animais econtrados abaixo";

            dgvUtiliDois.DataSource = relatorio.BuscaAnimais();
        }

        private void btnRendimento_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Informe um dia desejado para ver o movimento do mesmo (Dia/Mês/Ano): ";
            mskDiaBuscado.Show();
            lblAlgum.Text = "Rendimento do dia escolhido abaixo";


            dia = mskDiaBuscado.Text;

            dgvUtiliDois.DataSource = relatorio.MovimentoDia(dia);
        }
    }
}
