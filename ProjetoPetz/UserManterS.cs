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
    public partial class UserManterS : UserControl
    {
        ClassAnimal animal = new ClassAnimal();
        ClassAgendamento agendamento = new ClassAgendamento();
        ClassFuncionario funcionario = new ClassFuncionario();
        ClassServico servico = new ClassServico();
        string codAgendamentoClicado = "";
        string codAnimalClicado = "";
        string codFuncionarioClicado = "";
        string codServicoClicado = "";
        bool validar;


        public UserManterS()
        {
            InitializeComponent();
        }

        private void btnInserirS_Click(object sender, EventArgs e)
        {
            agendamento.codAnimal = txtCodAnimal.Text;
            agendamento.codServico = txtCodServ.Text;
            agendamento.codVet = txtCodVet.Text;
            agendamento.dataPrevista = mskDataPrev.Text;
            agendamento.horaPrevista = mskHoraPrev.Text;

            DataTable dt = agendamento.RetTodosAgendamentos();
            string ultimoId = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codExecucao"].ToString().Replace("PREV", "") : "0";
            ultimoId = "PREV" + (int.Parse(ultimoId) + 1).ToString().PadLeft(3, '0');

            agendamento.codAgendamento = ultimoId;

            if (validar == true)
            {
                if (txtCodAnimal.Text == "" || txtCodServ.Text == "" || txtCodVet.Text == ""
                    || mskDataPrev.Text == "" || mskHoraPrev.Text == "")
                {
                    MessageBox.Show("  Favor preencher todos os dados!");
                }
                else
                {
                    if (agendamento.Inserir() == true)
                    {
                        MessageBox.Show("   Agendamento cadastrado com sucesso!");
                        dgvAgendamento.DataSource = agendamento.RetTodosAgendamentos();
                        validar = false;
                    }
                }
            }else
            {
                MessageBox.Show("Valide o cadatro primeiro!");
            }
        }

        private void btnEditarS_Click(object sender, EventArgs e)
        {
            agendamento.codAnimal = txtCodAnimal.Text;
            agendamento.codServico = txtCodServ.Text;
            agendamento.codVet = txtCodVet.Text;
            agendamento.dataPrevista = mskDataPrev.Text;
            agendamento.horaPrevista = mskHoraPrev.Text;


            if (agendamento.Editar(codAgendamentoClicado) == true)
            {
                MessageBox.Show("    Agendamento editado com sucesso!");
                dgvAgendamento.DataSource = agendamento.RetTodosAgendamentos();
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
                agendamento.codAnimal = txtCodAnimal.Text;
                agendamento.codServico = txtCodServ.Text;
                agendamento.codVet = txtCodVet.Text;
                agendamento.dataPrevista = mskDataPrev.Text;
                agendamento.horaPrevista = mskHoraPrev.Text;

                if (agendamento.Excluir(codAgendamentoClicado) == true)
                {
                    MessageBox.Show("   Agendamento exclúido com sucesso!");
                    dgvAgendamento.DataSource = agendamento.RetTodosAgendamentos();
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
        private void dgvAgendamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgendamento.Rows[e.RowIndex].Cells["codExecucao"].
                    Value.ToString() != "")
            {
                codAgendamentoClicado = dgvAgendamento.Rows
                    [e.RowIndex].Cells["codExecucao"].Value.ToString();
            }

            txtCodAnimal.Text = dgvAgendamento.Rows[e.RowIndex].Cells["animal_codAnimal"].Value.ToString();
            txtCodServ.Text = dgvAgendamento.Rows[e.RowIndex].Cells["servico_codServico"].Value.ToString();
            txtCodVet.Text = dgvAgendamento.Rows[e.RowIndex].Cells["funcionario_codFuncionario"].Value.ToString();
            mskDataPrev.Text = dgvAgendamento.Rows[e.RowIndex].Cells["dataPrevista"].Value.ToString();
            mskHoraPrev.Text = dgvAgendamento.Rows[e.RowIndex].Cells["horaPrevista"].Value.ToString();




            dgvAgendamento.DataSource = agendamento.RetTodosAgendamentos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvAgendamento.DataSource = agendamento.RetTodosAgendamentos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvAgendamento.DataSource = agendamento.RetAgendamentosData(txtBuscar.Text);

        }

        private void UserManterS_Load(object sender, EventArgs e)
        {

        }

        private void dgvDoAmimal_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void dgvDoServiço_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}


