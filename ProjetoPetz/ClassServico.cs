using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoZeeDog
{

    class ClassServico
    {

        // Propriedades
        public string CodServico { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorServico { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO Servico (codServico,nome,descricao,valorServico) " +
                    "VALUES ('{0}','{1}','{2}','{3}')",CodServico, Nome, Descricao, ValorServico));


                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao inserir cliente! ");
            }
        }
        // Retorna os serviços cadastros no DGv
        public DataTable RetTodosServicos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM Servico"));


            bd.Desconectar();

            return dt;
        }
        // Edita os serviços cadastrados
        public bool Editar(string codServicoClicado)
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE Servico SET nome = '{0}' , descricao = '{1}', valorServico = {2}"
                + " WHERE codServico LIKE '{3}'", Nome // arg 0
                , Descricao // arg 1
                , ValorServico // arg 2
                , codServicoClicado // arg 3
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
        // Exclui os serviços cadatrados
        public bool Excluir(string codServicoClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM Servico WHERE codServico = '{0}'",
                codServicoClicado));

            bd.Desconectar();

            return true;

        }
        // Retorna o serviços pelo o nome
        public DataTable RetServicosNome(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Servico WHERE nome like '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }
    }
}
