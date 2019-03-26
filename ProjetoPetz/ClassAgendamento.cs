using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoZeeDog
{
    class ClassAgendamento
    {
        // Propriedades 
        public string codAgendamento { get; set; }
        public string codAnimal { get; set; }
        public string codServico { get; set; }
        public string codVet { get; set; }
        public string dataPrevista { get; set; }
        public string horaPrevista { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO ExecucaoServico (codExecucao, animal_codAnimal,servico_codServico,funcionario_codFuncionario,dataPrevista, " +
                 "horaPrevista) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",codAgendamento, codAnimal, codServico, codVet
                 , dataPrevista, horaPrevista));


                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao inserir agendamento! ");
            }
        }
        // Retornar agendamentos cadastrados no banco
        public DataTable RetTodosAgendamentos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM ExecucaoServico"));


            bd.Desconectar();

            return dt;
        }
        // Função de editar os agendamentos
        public bool Editar(string codAgendamentoClicado)
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE ExecucaoServico SET animal_codAnimal = '{0}', servico_codServico = '{1}', funcionario_codFuncionario = '{2}', "
                + "dataPrevista = '{3}',horaPrevista = '{4}' WHERE codExecucao LIKE '{5}'", codAnimal // arg 0
                , codServico // arg 1
                , codVet // arg 2
                , dataPrevista // arg 3
                , horaPrevista                           
                ,codAgendamentoClicado
                ));



                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao editar agendamento! ");
            }
        }
        // Função de excluir os agendamentos no banco
        public bool Excluir(string codAgendamentoClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM ExecucaoServico WHERE codExecucao = '{0}'",
                codAgendamentoClicado));

            bd.Desconectar();

            return true;

        }
        // Retornar agendamentos de acordo com a data
        public DataTable RetAgendamentosData(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM ExecucaoServico WHERE dataPrevista like '%{0}%'", busca));
            
            bd.Desconectar();

            return dt;
        }
        // Retornar  as informações do funcionário junto do agendamento
        public DataTable RetServicosEVet()
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT E.dataPrevista,E.horaPrevista,F.codFuncionario,F.nome  FROM ExecucaoServico AS E INNER JOIN Funcionario AS F ON E.funcionario_codFuncionario = F.codFuncionario WHERE F.codTipo = 3"));

            bd.Desconectar();
            return dt;
        }
    }
}
