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
    public partial class UserExecucao : UserControl
    {
        string codAnimalClicado = "";
        string codFuncionarioClicado = "";
        string codServicoClicado = "";
        string codAgendamentoClicado = "";
        ClassAnimal animal = new ClassAnimal();
        ClassFuncionario funcionario = new ClassFuncionario();
        ClassServico servico = new ClassServico();
        ClassExecucao execucao = new ClassExecucao();
        bool validar;
        public UserExecucao()
        {
            InitializeComponent();
        }

        private void dgvDoAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDoAnimal.Rows[e.RowIndex].Cells["codAnimal"].
                 Value.ToString() != "")
            {
                codAnimalClicado = dgvDoAnimal.Rows
                    [e.RowIndex].Cells["codAnimal"].Value.ToString();


            }

            txtCodAnimal.Text = dgvDoAnimal.Rows[e.RowIndex].Cells["codAnimal"].Value.ToString();

        }

        private void dgvDoVet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDoVet.Rows[e.RowIndex].Cells["codFuncionario"].
                 Value.ToString() != "")
            {
                codFuncionarioClicado = dgvDoVet.Rows
                    [e.RowIndex].Cells["codFuncionario"].Value.ToString();


            }

            txtCodVet.Text = dgvDoVet.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString();
        }

        private void dgvDoServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDoServico.Rows[e.RowIndex].Cells["codServico"].
                 Value.ToString() != "")
            {
                codServicoClicado = dgvDoServico.Rows
                    [e.RowIndex].Cells["codServico"].Value.ToString();


            }

            txtCodServ.Text = dgvDoServico.Rows[e.RowIndex].Cells["codServico"].Value.ToString();

        }

        private void btnAtuA_Click(object sender, EventArgs e)
        {
            dgvDoAnimal.DataSource = animal.RetTodosAnimal();

            this.dgvDoAnimal.Columns["cliente_codCliente"].Visible = false;
            this.dgvDoAnimal.Columns["anoNascimento"].Visible = false;
            this.dgvDoAnimal.Columns["peso"].Visible = false;
            this.dgvDoAnimal.Columns["grupo"].Visible = false;
            this.dgvDoAnimal.Columns["raca"].Visible = false;
            this.dgvDoAnimal.Columns["genero"].Visible = false;
            this.dgvDoAnimal.Columns["vacinacao"].Visible = false;
            this.dgvDoAnimal.Columns["comportamento"].Visible = false;

        }

        private void btnAtuV_Click(object sender, EventArgs e)
        {
            dgvDoVet.DataSource = funcionario.RetVet();

            this.dgvDoVet.Columns["dataCadastro"].Visible = false;
            this.dgvDoVet.Columns["dataNascimento"].Visible = false;
            this.dgvDoVet.Columns["telefone"].Visible = false;
            this.dgvDoVet.Columns["email"].Visible = false;
            this.dgvDoVet.Columns["endereco"].Visible = false;
            this.dgvDoVet.Columns["cidade"].Visible = false;
            this.dgvDoVet.Columns["estado"].Visible = false;
            this.dgvDoVet.Columns["pais"].Visible = false;
            this.dgvDoVet.Columns["senha"].Visible = false;
        }

        private void btnAtuS_Click(object sender, EventArgs e)
        {
            dgvDoServico.DataSource = servico.RetTodosServicos();

            this.dgvDoServico.Columns["descricao"].Visible = false;
            this.dgvDoServico.Columns["valorServico"].Visible = false;
        }

        private void dgvAgendamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgendamento.Rows[e.RowIndex].Cells["codExecucaoA"].
                    Value.ToString() != "")
            {
                codAgendamentoClicado = dgvAgendamento.Rows
                    [e.RowIndex].Cells["codExecucaoA"].Value.ToString();
            }

            txtCodAnimal.Text = dgvAgendamento.Rows[e.RowIndex].Cells["animal_codAnimal"].Value.ToString();
            txtCodServ.Text = dgvAgendamento.Rows[e.RowIndex].Cells["servico_codServico"].Value.ToString();
            txtCodVet.Text = dgvAgendamento.Rows[e.RowIndex].Cells["funcionario_codFuncionario"].Value.ToString();
            mskDataExec.Text = dgvAgendamento.Rows[e.RowIndex].Cells["dataExecucao"].Value.ToString();
            mskHoraExec.Text = dgvAgendamento.Rows[e.RowIndex].Cells["horaExecucao"].Value.ToString();




            dgvAgendamento.DataSource = execucao.RetTodosAgendamentos();
        }

        private void btnInserirS_Click(object sender, EventArgs e)
        {
             execucao.codAnimal = txtCodAnimal.Text;
            execucao.codServico = txtCodServ.Text;
            execucao.codVet = txtCodVet.Text;
            execucao.dataExecucao = mskDataExec.Text;
            execucao.horaExecucao = mskHoraExec.Text;

            DataTable dt = execucao.RetTodosAgendamentos();
            string ultimoId = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codExecucaoA"].ToString().Replace("EXEC", "") : "0";
            ultimoId = "EXEC" + (int.Parse(ultimoId) + 1).ToString().PadLeft(3, '0');

            execucao.codExecucao = ultimoId;
            if (validar == true)
            {
                if (txtCodAnimal.Text == "" || txtCodServ.Text == "" || txtCodVet.Text == ""
                    || mskDataExec.Text == "" || mskHoraExec.Text == "")
                {
                    MessageBox.Show("  Favor preencher todos os dados!");
                }
                else
                {
                    if (execucao.Inserir() == true)
                    {
                        MessageBox.Show("   Agendamento cadastrado com sucesso!");
                        dgvAgendamento.DataSource = execucao.RetTodosAgendamentos();
                        validar = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Valide o cadatro primeiro!");
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtCodAnimal.Text.Length < 1 || txtCodServ.Text.Length < 1 || txtCodVet.Text.Length < 1)
            {
                MessageBox.Show("Favor preencher corretamente os dados!");
                validar = false;
            }
            else
            {
                validar = true;
                MessageBox.Show("Validação realizada com Sucesso, pressione salvar para concluir!");
            }
        }

        private void btnEditarS_Click(object sender, EventArgs e)
        {
            execucao.codAnimal = txtCodAnimal.Text;
            execucao.codServico = txtCodServ.Text;
            execucao.codVet = txtCodVet.Text;
            execucao.dataExecucao = mskDataExec.Text;
            execucao.horaExecucao = mskHoraExec.Text;


            if (execucao.Editar(codAgendamentoClicado) == true)
            {
                MessageBox.Show("    Agendamento editado com sucesso!");
                dgvAgendamento.DataSource = execucao.RetTodosAgendamentos();
            }
            else
            {
                MessageBox.Show("    Erro ao editar o agendamento!");
            }

        }

        private void btnExcluirS_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o funcionário?", "Confirmação da Exclusão", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                execucao.codAnimal = txtCodAnimal.Text;
                execucao.codServico = txtCodServ.Text;
                execucao.codVet = txtCodVet.Text;
                execucao.dataExecucao = mskDataExec.Text;
                execucao.horaExecucao = mskHoraExec.Text;

                if (execucao.Excluir(codAgendamentoClicado) == true)
                {
                    MessageBox.Show("   Agendamento exclúido com sucesso!");
                    dgvAgendamento.DataSource = execucao.RetTodosAgendamentos();
                }
                else
                {
                    MessageBox.Show("   Erro ao excluir o agendamneto!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // nada acontece
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvAgendamento.DataSource = execucao.RetTodosAgendamentos();
        }
    }
}

