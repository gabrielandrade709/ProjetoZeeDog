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
    public partial class UserCliente : UserControl
    {
        ClassCliente cliente = new ClassCliente();
        string codClienteClicado = "";
        string date = DateTime.Now.ToString();
        bool validar;

        public UserCliente()
        {
            InitializeComponent();
        }

        private void btnInserirC_Click(object sender, EventArgs e)
        {
            if (cliente.VerificarEmail(txtEmail.Text) == 0)
            {
                if (cliente.VerificarRg(mskRg.Text) == 0)
                {
                    DataTable dt = cliente.RetTodosClientes();
                    string ultimoId = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codCliente"].ToString().Replace("CLIE", "") : "0";
                    ultimoId = "CLIE" + (int.Parse(ultimoId) + 1).ToString().PadLeft(3, '0');

                    cliente.codCliente = ultimoId;

                    cliente.dataCad = date;
                    cliente.dataNasc = mskDataNasc.Text;
                    cliente.cidade = txtCidade.Text;
                    cliente.email = txtEmail.Text;
                    cliente.endereco = txtEndereco.Text;
                    cliente.pais = txtPais.Text;
                    cliente.telefone = mskTelefone.Text;
                    cliente.rg = mskRg.Text;
                    cliente.nome = txtNomeC.Text;
                    cliente.estado = txtEstado.Text;


                    if (validar == true)
                    {

                        if (cliente.Inserir() == true)
                        {
                            MessageBox.Show("Cliente inserido com sucesso!");
                            dgvClientes.DataSource = cliente.RetTodosClientes();
                            validar = false;

                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir cliente!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("    Valide o cadastro primeiro!");
                    }
                }
                else
                {
                    MessageBox.Show("  O RG já está cadastrado!");
                }
            }
            else
            {
                MessageBox.Show("  O Email já está cadastrado!");
            }
        }



        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows[e.RowIndex].Cells["codCliente"].
                Value.ToString() != "")
            {
                codClienteClicado = dgvClientes.Rows
                    [e.RowIndex].Cells["codCliente"].Value.ToString();
            }

            txtNomeC.Text = dgvClientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCidade.Text = dgvClientes.Rows[e.RowIndex].Cells["cidade"].Value.ToString();

            mskDataNasc.Text = dgvClientes.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString();
            txtEmail.Text = dgvClientes.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtEstado.Text = dgvClientes.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtPais.Text = dgvClientes.Rows[e.RowIndex].Cells["pais"].Value.ToString();
            mskTelefone.Text = dgvClientes.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtEndereco.Text = dgvClientes.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
            mskRg.Text = dgvClientes.Rows[e.RowIndex].Cells["rg"].Value.ToString();


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = cliente.RetTodosClientes();

        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            cliente.dataCad = date;
            cliente.dataNasc = mskDataNasc.Text;
            cliente.cidade = txtCidade.Text;
            cliente.email = txtEmail.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.pais = txtPais.Text;
            cliente.telefone = mskTelefone.Text;
            cliente.rg = mskRg.Text;
            cliente.nome = txtNomeC.Text;
            cliente.estado = txtEstado.Text;

            if (cliente.Editar(codClienteClicado) == true)
            {
                MessageBox.Show("Cliente editado com sucesso!");
                dgvClientes.DataSource = cliente.RetTodosClientes();

            }
            else
            {
                MessageBox.Show("Erro ao editar cliente!");
            }
        }

        private void btnExcluirC_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o funcionário?", "Confirmação da Exclusão", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cliente.dataCad = date;
                cliente.dataNasc = mskDataNasc.Text;
                cliente.cidade = txtCidade.Text;
                cliente.email = txtEmail.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.pais = txtPais.Text;
                cliente.telefone = mskTelefone.Text;
                cliente.rg = mskRg.Text;
                cliente.nome = txtNomeC.Text;
                cliente.estado = txtEstado.Text;

                if (cliente.Excluir(codClienteClicado) == true)
                {
                    MessageBox.Show("Cliente excluído com sucesso!");
                    dgvClientes.DataSource = cliente.RetTodosClientes();

                }
                else
                {
                    MessageBox.Show("Erro ao excluir cliente!");
                }
            } else if(dialogResult == DialogResult.No)
            {
                // Nada acontece
            }
        }
    
        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            bool num = false;

            if (txtEndereco.Text.Contains("1") || txtEndereco.Text.Contains("2") || txtEndereco.Text.Contains("3") ||
                txtEndereco.Text.Contains("4") || txtEndereco.Text.Contains("5") || txtEndereco.Text.Contains("6") || txtEndereco.Text.Contains("7") ||
                txtEndereco.Text.Contains("8") || txtEndereco.Text.Contains("9") || txtEndereco.Text.Contains("0"))
            {
                num = true;
            }

            if (num == true)
            {
                //OK
            }
            else
            {
                MessageBox.Show(" O endereço deve possuir letras e números!");
                txtEndereco.Text = "";
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = cliente.RetClientesRg(txtBuscar.Text);

        }

        private void txtNomeC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            bool validarEmail = false;
            if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
            {
                validarEmail = true;
            }
            if (validarEmail == true)
            {
                //OK
            }
            else
            {
                MessageBox.Show("Email inválido meu patrão");
                txtEmail.Text = "";
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if ((txtNomeC.Text.Length < 3 || txtPais.Text.Length < 3 || txtCidade.Text.Length < 3 || txtEmail.Text.Length < 3 || txtEndereco.Text.Length < 3 ||
                 txtEstado.Text.Length < 2 || txtPais.Text.Length < 3 || mskDataNasc.Text.Length < 3 || mskRg.Text.Length < 3 || mskTelefone.Text.Length < 3))
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
    }
}
