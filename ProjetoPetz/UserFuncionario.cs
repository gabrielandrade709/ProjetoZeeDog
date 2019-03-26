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
    public partial class UserFuncionario : UserControl
    {
        ClassFuncionario funcionario = new ClassFuncionario();
        string codFuncionarioClicado = "";
        string date = DateTime.Now.ToString();
        bool validar;

        public UserFuncionario()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvFunc.DataSource = funcionario.RetTodosFuncionarios();


        }

        private void btnInserirF_Click(object sender, EventArgs e)
        {


            if (funcionario.VerificarEmail(txtEmailF.Text) == 0)
            {
                if (funcionario.VerificarRg(mskRgF.Text) == 0)
                {
                    if (validar == true)
                    {

                        DataTable dt = funcionario.RetTodosFuncionarios();
                        string ultimoId = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codFuncionario"].ToString().Replace("FUNC", "") : "0";
                        ultimoId = "FUNC" + (int.Parse(ultimoId) + 1).ToString().PadLeft(3, '0');

                        funcionario.codFuncionario = ultimoId;
                        funcionario.dataCad = date;
                        funcionario.dataNasc = mskDataNascF.Text;
                        funcionario.cidade = txtCidadeF.Text;
                        funcionario.email = txtEmailF.Text;
                        funcionario.endereco = txtEnderecoF.Text;
                        funcionario.pais = txtPaisF.Text;
                        funcionario.telefone = mskTelefoneF.Text;
                        funcionario.rg = mskRgF.Text;
                        funcionario.nome = txtNomeF.Text;
                        funcionario.estado = txtEstadoF.Text;
                        funcionario.senha = txtSenha.Text;
                        funcionario.codTipo = int.Parse(cboTipoFunc.Text);
                        if (funcionario.Inserir() == true)
                        {
                            MessageBox.Show("Funcionário inserido com sucesso!");
                            dgvFunc.DataSource = funcionario.RetTodosFuncionarios();
                            validar = false;
                        }

                        else
                        {
                            MessageBox.Show("Erro ao inserir funcionário!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Favor validar primeiro!");

                    }
                }
                else
                {
                    MessageBox.Show(" O RG ja está cadastrado!");
                    mskRgF.Text = "";
                }
            }
            else
            {
                MessageBox.Show(" O email ja está cadastrado!");
                txtEmailF.Text = "";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoFunc.Text == "Administrador")
            {
                cboTipoFunc.Text = "1";
            }
        }

        private void cboTipoFunc_Leave(object sender, EventArgs e)
        {
            if (cboTipoFunc.Text == "Administrador")
            {
                cboTipoFunc.Text = "1";
            }
            else if (cboTipoFunc.Text == "Balconista")
            {
                cboTipoFunc.Text = "2";
            }
            else if (cboTipoFunc.Text == "Veterinário")
            {
                cboTipoFunc.Text = "3";
            }
        }

        private void btnEditarF_Click(object sender, EventArgs e)
        {
            funcionario.dataCad = date;
            funcionario.dataNasc = mskDataNascF.Text;
            funcionario.cidade = txtCidadeF.Text;
            funcionario.email = txtEmailF.Text;
            funcionario.endereco = txtEnderecoF.Text;
            funcionario.pais = txtPaisF.Text;
            funcionario.telefone = mskTelefoneF.Text;
            funcionario.rg = mskRgF.Text;
            funcionario.nome = txtNomeF.Text;
            funcionario.estado = txtEstadoF.Text;
            funcionario.senha = txtSenha.Text;
            funcionario.codTipo = int.Parse(cboTipoFunc.Text);


            if (funcionario.Editar(codFuncionarioClicado) == true)
            {
                MessageBox.Show("Funcionário editado com sucesso!");
                dgvFunc.DataSource = funcionario.RetTodosFuncionarios();

            }
            else
            {
                MessageBox.Show("Erro ao editar funcionário!");
            }
        }

        private void dgvFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                if (dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].
                    Value.ToString() != "")
                {
                    codFuncionarioClicado = dgvFunc.Rows
                        [e.RowIndex].Cells["codFuncionario"].Value.ToString();
                }

                mskDataNascF.Text = dgvFunc.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString();
                mskRgF.Text = dgvFunc.Rows[e.RowIndex].Cells["rg"].Value.ToString();
                mskTelefoneF.Text = dgvFunc.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
                txtCidadeF.Text = dgvFunc.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
                txtEmailF.Text = dgvFunc.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtEnderecoF.Text = dgvFunc.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
                txtEstadoF.Text = dgvFunc.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                txtNomeF.Text = dgvFunc.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtPaisF.Text = dgvFunc.Rows[e.RowIndex].Cells["pais"].Value.ToString();
                txtSenha.Text = dgvFunc.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                cboTipoFunc.Text = dgvFunc.Rows[e.RowIndex].Cells["codTipo"].Value.ToString();

            }

        }

        private void btnExcluirF_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o funcionário?", "Confirmação da Exclusão", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                funcionario.dataCad = date;
                funcionario.dataNasc = mskDataNascF.Text;
                funcionario.cidade = txtCidadeF.Text;
                funcionario.email = txtEmailF.Text;
                funcionario.endereco = txtEnderecoF.Text;
                funcionario.pais = txtPaisF.Text;
                funcionario.telefone = mskTelefoneF.Text;
                funcionario.rg = mskRgF.Text;
                funcionario.nome = txtNomeF.Text;
                funcionario.estado = txtEstadoF.Text;
                funcionario.senha = txtSenha.Text;
                funcionario.codTipo = int.Parse(cboTipoFunc.Text);


                if (funcionario.Excluir(codFuncionarioClicado) == true)
                {
                    MessageBox.Show("Funcionário excluído com sucesso!");
                    dgvFunc.DataSource = funcionario.RetTodosFuncionarios();

                }
                else
                {
                    MessageBox.Show("Erro ao excluir funcionário!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // nada acontece
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvFunc.DataSource = funcionario.RetFuncionariosRg(txtBuscar.Text);

        }

        private void UserFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txtEmailF_Leave(object sender, EventArgs e)
        {
            bool validarEmail = false;
            if (txtEmailF.Text.Contains("@") && txtEmailF.Text.Contains("."))
            {
                validarEmail = true;
            }
            if (validarEmail == true)
            {
                //OK
            }
            else
            {
                MessageBox.Show("Favor inserir um email válido");
                txtEmailF.Text = "";
            }
        }

        private void txtEnderecoF_Leave(object sender, EventArgs e)
        {
            bool end = false;

            if (txtEnderecoF.Text.Contains("1") || txtEnderecoF.Text.Contains("2") || txtEnderecoF.Text.Contains("3") ||
                txtEnderecoF.Text.Contains("4") || txtEnderecoF.Text.Contains("5") || txtEnderecoF.Text.Contains("6") || txtEnderecoF.Text.Contains("7") ||
                txtEnderecoF.Text.Contains("8") || txtEnderecoF.Text.Contains("9") || txtEnderecoF.Text.Contains("0"))
            {
                end = true;
            }

            if (end == true)
            {
                //OK
            }
            else
            {
                MessageBox.Show(" O endereço deve possuir letras e números!");
                txtEnderecoF.Text = "";
            }
        }

        private void txtNomeF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Text box aceitar apenas letras
            if (!(char.IsLetter(e.KeyChar)) // Apenas letras
                && !(e.KeyChar == (char)Keys.Enter) // E enter
                && !(e.KeyChar == (char)Keys.Back) // E basckspace
                && !(e.KeyChar == (char)Keys.Space)) // E basckspace

            {
                e.Handled = true;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if ((txtNomeF.Text.Length < 3 || txtPaisF.Text.Length < 3 || txtCidadeF.Text.Length < 3 || txtEmailF.Text.Length < 3 || txtEnderecoF.Text.Length < 3 ||
                txtEstadoF.Text.Length < 2 || txtPaisF.Text.Length < 3 || mskDataNascF.Text.Length < 3 || mskRgF.Text.Length < 3 || mskTelefoneF.Text.Length < 3
                ))
            {
                MessageBox.Show("Todos os campos devem conter ao menos 3 caracteres!");
                validar = false;
            }
            else
            {
                MessageBox.Show("Validação realizada com Sucesso, pressione salvar para concluir!");
                validar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            bool senha = false;

            if (txtSenha.Text.Contains("1") || txtSenha.Text.Contains("2") || txtSenha.Text.Contains("3") ||
                txtSenha.Text.Contains("4") || txtSenha.Text.Contains("5") || txtSenha.Text.Contains("6") || txtSenha.Text.Contains("7") ||
                txtSenha.Text.Contains("8") || txtSenha.Text.Contains("9") || txtSenha.Text.Contains("0"))
            {
                senha = true;
            }

            if (senha == true)
            {
                //OK
            }
            else
            {
                MessageBox.Show(" A senha deve possuir letras e números!");
                txtSenha.Text = "";
            }
        }
    }
}
