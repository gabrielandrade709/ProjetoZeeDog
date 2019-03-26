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
    public partial class UserAgendarS : UserControl
    {
        ClassServico servico = new ClassServico();
        string codServicoClicado = "";

        public UserAgendarS()
        {
            InitializeComponent();
        }

        private void btnInserirS_Click(object sender, EventArgs e)
        {
            servico.Nome = cbmServico.Text;
            servico.Descricao = rtbDescricao.Text;
            servico.ValorServico = decimal.Parse(txtValorServico.Text);

            DataTable dt = servico.RetTodosServicos();
            string ultimoId = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codServico"].ToString().Replace("SERV", "") : "0";
            ultimoId = "SERV" + (int.Parse(ultimoId) + 1).ToString().PadLeft(3, '0');

            servico.CodServico = ultimoId;

            if (cbmServico.Text == "" || rtbDescricao.Text == "" || txtValorServico.Text == "")
            {
                MessageBox.Show("Favor preencher todos os dados! ");
            }
            else if(servico.Inserir() == true){
                MessageBox.Show("O serviço foi cadastrado com sucesso!");
                dgvServico.DataSource = servico.RetTodosServicos();
            }
        }

        private void btnExcluirS_Click(object sender, EventArgs e)
        {
            servico.Nome = cbmServico.Text;
            servico.Descricao = rtbDescricao.Text;
            servico.ValorServico = decimal.Parse(txtValorServico.Text);
            
            if(servico.Excluir(codServicoClicado) == true)
            {
                MessageBox.Show("   O serviço foi excluído com sucesso!");
            }

            dgvServico.DataSource = servico.RetTodosServicos();
        }

        private void btnEditarS_Click(object sender, EventArgs e)
        {
            servico.Nome = cbmServico.Text;
            servico.Descricao = rtbDescricao.Text;
            servico.ValorServico = decimal.Parse(txtValorServico.Text);

            if (servico.Editar(codServicoClicado) == true)
            {
                MessageBox.Show("   Serviço editado com êxito!");
                dgvServico.DataSource = servico.RetTodosServicos();
            }
            else
            {
                MessageBox.Show("   Erro ao editar o usuário!");

            }
        }

        private void UserAgendarS_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvServico.DataSource = servico.RetTodosServicos();
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServico.Rows[e.RowIndex].Cells["codServico"].
                    Value.ToString() != "")
            {
                codServicoClicado = dgvServico.Rows
                    [e.RowIndex].Cells["codServico"].Value.ToString();
            }

            cbmServico.Text = dgvServico.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtValorServico.Text = dgvServico.Rows[e.RowIndex].Cells["valorServico"].Value.ToString();
            rtbDescricao.Text = dgvServico.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            

            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvServico.DataSource = servico.RetServicosNome(txtBuscar.Text);
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtValorServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) // Apenas letras
                && !(e.KeyChar == (char)Keys.Enter) // E enter
                && !(e.KeyChar == (char)Keys.Back) // E basckspace
                && !(e.KeyChar == (char)Keys.Space)) // E basckspace

            {
                e.Handled = true;
            }
        }
    }
}
