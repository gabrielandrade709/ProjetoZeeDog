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
    public partial class UserManterA : UserControl
    {
        ClassAnimal animal = new ClassAnimal();
        ClassCliente cliente = new ClassCliente();
        string codAnimalClicado = "";
        string codClienteClicado = "";
        bool validar;

        public UserManterA()
        {
            InitializeComponent();
        }

        private void btnInserirA_Click(object sender, EventArgs e)
        {


            if (animal.VerificarCodigo(txtCodCliente.Text) > 0)
            {
                if (validar == true)
                {
                    animal.anoNascimento = int.Parse(txtAnoNasc.Text);
                    animal.codCliente = txtCodCliente.Text;
                    animal.comportamento = txtComportamento.Text;
                    animal.genero = cboGenero.Text;
                    animal.grupo = txtGrupo.Text;
                    animal.nome = txtNomeA.Text;
                    animal.peso = int.Parse(txtPeso.Text);
                    animal.raca = txtRaca.Text;
                    animal.vacinacao = cboVacinacao.Text;

                    DataTable dt = animal.RetTodosAnimal();
                    string ultimoId = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codAnimal"].ToString().Replace("ANIM", "") : "0";
                    ultimoId = "ANIM" + (int.Parse(ultimoId) + 1).ToString().PadLeft(3, '0');

                    animal.codAnimal = ultimoId;
                    if (animal.Inserir() == true)
                    {
                        MessageBox.Show("   Animal cadastrado com sucesso!");
                        dgvAnimais.DataSource = animal.RetTodosAnimal();
                        validar = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar animal");
                    }
                }
                else
                {
                    MessageBox.Show(" Favor validar o cadastro primeiro!");
                }
            }else
            {
                MessageBox.Show(" O cliente não existe, favor cadastrá-lo primeiro! ");
                txtCodCliente.Text = "";
            }
        }
        private void dgvAnimais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                if (dgvAnimais.Rows[e.RowIndex].Cells["codAnimal"].
                    Value.ToString() != "")
                {
                    codAnimalClicado = dgvAnimais.Rows
                        [e.RowIndex].Cells["codAnimal"].Value.ToString();
                }

                txtAnoNasc.Text = dgvAnimais.Rows[e.RowIndex].Cells["anoNascimento"].Value.ToString();
                txtCodCliente.Text = dgvAnimais.Rows[e.RowIndex].Cells["cliente_codCliente"].Value.ToString();
                txtComportamento.Text = dgvAnimais.Rows[e.RowIndex].Cells["comportamento"].Value.ToString();
                txtGrupo.Text = dgvAnimais.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
                txtNomeA.Text = dgvAnimais.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtPeso.Text = dgvAnimais.Rows[e.RowIndex].Cells["peso"].Value.ToString();
                txtRaca.Text = dgvAnimais.Rows[e.RowIndex].Cells["raca"].Value.ToString();
                cboGenero.Text = dgvAnimais.Rows[e.RowIndex].Cells["genero"].Value.ToString();
                cboVacinacao.Text = dgvAnimais.Rows[e.RowIndex].Cells["vacinacao"].Value.ToString();
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvAnimais.DataSource = animal.RetTodosAnimal();

        }

        private void btnEditarA_Click(object sender, EventArgs e)
        {
            animal.anoNascimento = int.Parse(txtAnoNasc.Text);
            animal.codCliente = txtCodCliente.Text;
            animal.comportamento = txtComportamento.Text;
            animal.genero = cboGenero.Text;
            animal.grupo = txtGrupo.Text;
            animal.nome = txtNomeA.Text;
            animal.peso = int.Parse(txtPeso.Text);
            animal.raca = txtRaca.Text;
            animal.vacinacao = cboVacinacao.Text;

            if (animal.Editar(codAnimalClicado) == true)
            {
                MessageBox.Show("   Animal editado com sucesso!");
                dgvAnimais.DataSource = animal.RetTodosAnimal();
            }
            else
            {
                MessageBox.Show("Erro ao editar animal");
            }
        }

        private void btnExcluirA_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o funcionário?", "Confirmação da Exclusão", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                animal.anoNascimento = int.Parse(txtAnoNasc.Text);
                animal.codCliente = txtCodCliente.Text;
                animal.comportamento = txtComportamento.Text;
                animal.genero = cboGenero.Text;
                animal.grupo = txtGrupo.Text;
                animal.nome = txtNomeA.Text;
                animal.peso = int.Parse(txtPeso.Text);
                animal.raca = txtRaca.Text;
                animal.vacinacao = cboVacinacao.Text;

                if (animal.Excluir(codAnimalClicado) == true)
                {
                    MessageBox.Show("   Animal excluído com sucesso!");
                    dgvAnimais.DataSource = animal.RetTodosAnimal();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir animal");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // Nada acontece
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvAnimais.DataSource = animal.RetAnimaisNome(txtBuscar.Text);

        }

        private void dgvDono_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                if (dgvDono.Rows[e.RowIndex].Cells["codCliente"].
                    Value.ToString() != "")
                {
                    codClienteClicado = dgvDono.Rows
                        [e.RowIndex].Cells["codCliente"].Value.ToString();


                }

                txtCodCliente.Text = dgvDono.Rows[e.RowIndex].Cells["codCliente"].Value.ToString();


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDono.DataSource = cliente.RetTodosClientes();

            this.dgvDono.Columns["dataNascimento"].Visible = false;
            this.dgvDono.Columns["dataCadastro"].Visible = false;
            this.dgvDono.Columns["rg"].Visible = false;
            this.dgvDono.Columns["telefone"].Visible = false;
            this.dgvDono.Columns["email"].Visible = false;
            this.dgvDono.Columns["endereco"].Visible = false;
            this.dgvDono.Columns["cidade"].Visible = false;
            this.dgvDono.Columns["estado"].Visible = false;
            this.dgvDono.Columns["pais"].Visible = false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if ((txtAnoNasc.Text.Length < 3 || txtComportamento.Text.Length < 3 || txtGrupo.Text.Length < 3 || txtRaca.Text.Length < 3 || cboGenero.Text.Length < 3 || cboVacinacao.Text.Length < 3 || int.Parse(txtAnoNasc.Text) > 2018))
            {
                MessageBox.Show("Favor preencher corretamente todos os campos!");
                validar = false;
            }
            else
            {
                MessageBox.Show("Validação realizada com Sucesso, pressione salvar para concluir!");
                validar = true;
            }
        }
    }
}
