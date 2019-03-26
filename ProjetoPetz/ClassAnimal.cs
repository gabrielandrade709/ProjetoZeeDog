using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoZeeDog
{
    class ClassAnimal
    {
        ClassAcessoBD bd = new ClassAcessoBD();

        // Propriedades dos animais
        public string codAnimal { get; set; }
        public string codCliente { get; set; }
        public string nome { get; set; }
        public int anoNascimento { get; set; }
        public float peso { get; set; }
        public string grupo { get; set; }
        public string raca { get; set; }
        public string genero { get; set; }
        public string vacinacao { get; set; }
        public string comportamento{ get; set; }

        public bool Inserir()
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO Animal (codAnimal, cliente_codCliente, nome, anoNascimento, peso, " +
                    " grupo, raca, genero, vacinacao, comportamento) VALUES ('{0}','{1}','{2}',{3},{4},'{5}','{6}', '{7}', '{8}','{9}')",codAnimal, codCliente,
                    nome, anoNascimento, peso, grupo, raca, genero, vacinacao, comportamento));


                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao inserir animal! ");
            }
        }
        // Retorna os animais cadastrados o banco
        public DataTable RetTodosAnimal()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM Animal"));


            bd.Desconectar();

            return dt;
        }
        // Função de editar os animais cadastrados
        public bool Editar(string codAnimalClicado)
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE Animal SET cliente_codCliente = '{0}', nome = '{1}', anoNascimento = {2},"
                + "peso = {3}, grupo = '{4}', raca = '{5}', genero = '{6}', vacinacao = '{7}', comportamento = '{8}' WHERE " + 
                " codAnimal LIKE '{9}'", codCliente // arg 0
                , nome // arg 1
                , anoNascimento // arg 2
                , peso
                , grupo 
                , raca
                , genero
                ,vacinacao , comportamento , codAnimalClicado
                ));



                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao editar animal! ");
            }
        }
        // Função de excluir os animais cadasrados
        public bool Excluir(string codAnimalClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM Animal WHERE codAnimal = '{0}'",
                codAnimalClicado));

            bd.Desconectar();

            return true;

        }
        // Buscar animal de acordo com o nome
        public DataTable RetAnimaisNome(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Animal WHERE nome like '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }
        // Retorna o cliente de acordo com a chave estrangeira
        public int VerificarCodigo(string cod)
        {
            int ver;
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Cliente WHERE codCliente = '{0}'", cod));
            bd.Conectar();
            ver = dt.Rows.Count;
            bd.Desconectar();

            return ver;
        }
    }
}
