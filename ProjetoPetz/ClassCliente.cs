using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoZeeDog
{
    class ClassCliente
    {
        ClassAcessoBD bd = new ClassAcessoBD();


        // Propriedades dos clientes
        public string codCliente { get; set; }
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

        public bool Inserir()
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO Cliente (codCliente, dataCadastro,dataNascimento, nome,rg, " +
                    " telefone, email, endereco, cidade, estado, pais) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}', '{8}', '{9}','{10}')", codCliente, dataCad,
                    dataNasc, nome, rg, telefone, email, endereco, cidade, estado, pais));


                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao inserir cliente! ");
            }
        }
        // Retorna os clientes cadastrados no banco
        public DataTable RetTodosClientes()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM Cliente"));


            bd.Desconectar();

            return dt;
        }

        // Edita os clientes cadastrados no banco
        public bool Editar(string codClienteClicado)
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE Cliente SET dataCadastro = '{0}', dataNascimento = '{1}', nome = '{2}',"
                + "rg = '{3}', telefone = '{4}', email = '{5}',endereco = '{6}', cidade = '{7}', estado = '{8}', pais = '{9}' WHERE " +
                " codCliente LIKE '{10}'", dataCad // arg 0
                , dataNasc // arg 1
                , nome // arg 2
                , rg
                , telefone
                , email
                , endereco
                , cidade, estado, pais, codClienteClicado
                ));



                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao editar cliente! ");
            }
        }
        // Exclui os clientes cadastrados no banco
        public bool Excluir(string codClienteClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM Cliente WHERE codCliente = '{0}'",
                codClienteClicado));

            bd.Desconectar();

            return true;

        }

        // Busca clientes de acordo com o RG
        public DataTable RetClientesRg(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Cliente WHERE rg like '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }
        // Verifica se o Rg ja foi cadastrados

        public int VerificarRg(string rg)
        {
            int z;

            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Cliente WHERE rg = '{0}' ", rg));

            bd.Conectar();

            z = dt.Rows.Count;

            bd.Desconectar();

            // Caso exista algum rg preenchido retorna 1

            return z;


        }

        // Verifica se o email preenchido ja foi cadastrado
        public int VerificarEmail(string email)
        {
            int z;

            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Cliente WHERE email = '{0}' ", email));

            bd.Conectar();

            z = dt.Rows.Count;

            bd.Desconectar();

            // Caso exista algum email preenchido retorna 1

            return z;


        }

    }
}
