using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoZeeDog
{
    class ClassFuncionario
    {
        ClassAcessoBD bd = new ClassAcessoBD();
        // Propriedades dos funcionário
        public string codFuncionario { get; set; }
        public string dataCad { get; set; }
        public string dataNasc { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }
        public int codTipo { get; set; }
        public string senha { get; set; }

        public bool Inserir()
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO Funcionario (codFuncionario,dataCadastro,dataNascimento,nome,rg " +
                    ",telefone, email, endereco, cidade, estado, pais,codTipo,senha) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11},'{12}')",
                    codFuncionario, dataCad,
                    dataNasc, nome, rg, telefone, email, endereco, cidade, estado, pais, codTipo, senha));



                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao inserir funcionario! ");
            }
        }
        // Retorna os funcionários cadastrados no banco de dados
        public DataTable RetTodosFuncionarios()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM Funcionario"));


            bd.Desconectar();

            return dt;
        }
        // Edita os funcionários cadastrados
        public bool Editar(string codFuncionarioClicado)
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE Funcionario SET dataCadastro = '{0}', dataNascimento = '{1}', nome = '{2}',"
                + "rg = '{3}', telefone = '{4}', email = '{5}',endereco = '{6}', cidade = '{7}', estado = '{8}', pais = '{9}', codTipo = {10}, senha = '{11}' WHERE " +
                " codFuncionario LIKE '{12}'", dataCad // arg 0
                , dataNasc // arg 1
                , nome // arg 2
                , rg
                , telefone
                , email
                , endereco
                , cidade, estado, pais, codTipo, senha, codFuncionarioClicado
                ));



                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao editar funcionario! ");
            }
        }
        // Exclui os funcionários cadastrados
        public bool Excluir(string codFuncionarioClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM Funcionario WHERE codFuncionario = '{0}'",
                codFuncionarioClicado));

            bd.Desconectar();

            return true;

        }
        // Verifica o login e a senha de um funcionário para ele realizar o login
        public DataTable RealizarLogin()
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario" +
                " WHERE email LIKE '{0}' AND senha LIKE '{1}'", email, senha));

            bd.Desconectar();

            return dt;
        }
        // Busca funcionários de acordo com o RG
        public DataTable RetFuncionariosRg(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE rg like '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }
        // Verifica se o Rg ja foi cadastrado
        public int VerificarRg(string rg)
        {
            int z;

            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE rg = '{0}' ", rg));

            bd.Conectar();

            z = dt.Rows.Count;

            bd.Desconectar();

            // Caso exista algum rg preenchido retorna 1

            return z;


        }
        // Verifica se o email ja foi cadastrado
        public int VerificarEmail(string email)
        {
            int z;

            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE email = '{0}' ", email));

            bd.Conectar();

            z = dt.Rows.Count;

            bd.Desconectar();

            // Caso exista algum email preenchido retorna 1

            return z;


        }
        // Retorna funcionários que são veterinários
        public DataTable RetVet()
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE codTipo = 3"));

            bd.Desconectar();

            return dt;
        }


    }
}
