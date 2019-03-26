using System;
//1º Passo: Importar bibliotecas 
//de banco de dados
using System.Data;
using System.Data.SqlClient;


namespace ProjetoZeeDog
{
    class ClassAcessoBD
    {

        //2º Passo: Criação dos Objetos

        //Responsável pela conexão com o bd
        private SqlConnection con;

        //Responsável pela execução do comando select  
        private SqlDataAdapter da;

        //Responsável pela execução do INSERT/UPDATE/DELETE
        private SqlCommand cmd;

        //Reponsável por retornar o resultado de um select
        private DataTable dt;


        //3º Passo: Definindo os parâmetros para 
        //criar string de conexão 
        private string server = @"(localdb)\MSSQLLocalDB";// nome do servidor sqlServer
        private string database = "bdZeeDog"; //nome do database

        //Método: CONECTAR
        public void Conectar()
        {
            //Verifica se conexão já está aberta
            if (con != null)
                con.Close(); //fecha a conexão

            //Define a string de conexão
            string conStr = String.Format("server={0};" +
                "Initial Catalog={1};" +
                "Integrated Security=SSPI", server, database);

            try
            {
                //Recebe a string de conexão para 
                // conectar ao banco
                con = new SqlConnection(conStr);
                con.Open(); // abre a conexão
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                throw new Exception(ex.Message
                    + "Erro ao abrir conexão"); // Retorna mensagem de erro ao usuário
            }

        }

        //Método DESCONECTAR
        public void Desconectar()
        {
            //Define a string de conexão
            string conStr = String.Format("server={0};" +
                " Initial Catalog={1};" +
                "Integrated Security=SSPI", server, database);

            try
            {
                con = new SqlConnection(conStr); //Recebe a string de conexão para conectar ao banco
                con.Close(); // fecha a conexão
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                throw new Exception(ex.Message +
                    "Erro ao fechar conexão."
                    ); // Retorna mensagem de erro ao usuário
            }
        }

        //Criando o Método para executar comandos 
        ///INSERT/UPDATE/DELETE
        public void ExecutarComandosSql(string comandoSql)
        {
            try
            {
                //Informa qual comando executar em qual conexão
                cmd = new SqlCommand(comandoSql, con);

                //Executa o comando acima no bd
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                throw new Exception(ex.Message +
                    "Erro ao executar comando de " +
                    "inserir, editar ou deletar.");
            }

        }

        //Criando o Método para executar comandos SELECT
        public DataTable RetDataTable(string sql)
        {
            try
            {
                //Instancia o dataTable
                dt = new DataTable();

                //Preenche o adapter com comando sql
                da = new SqlDataAdapter(sql, con);

                //Preenche o objeto dt com os dados 
                //retornados do select
                da.Fill(dt);

                return dt; //Retorna o dataTable   
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                // Retorna mensagem de erro ao usuário
                throw new Exception(ex.Message +
                   "Erro ao retornar DataTable.");
            }

        }

    }
}
