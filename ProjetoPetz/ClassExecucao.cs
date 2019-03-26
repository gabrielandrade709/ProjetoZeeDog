using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoZeeDog
{
    class ClassExecucao
    {
        // Propriedades 
        public string codExecucao { get; set; }
        public string codAnimal { get; set; }
        public string codServico { get; set; }
        public string codVet { get; set; }
        public string dataExecucao { get; set; }
        public string horaExecucao { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO ExecucaoAgendamento (codExecucaoA,animal_codAnimal,servico_codServico,funcionario_codFuncionario,dataExecucao, " +
                 "horaExecucao) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",codExecucao, codAnimal, codServico, codVet
                 , dataExecucao, horaExecucao));


                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao inserir agendamento! ");
            }
        }
        // Retorna os agendamentos cadastrados
        public DataTable RetTodosAgendamentos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM ExecucaoAgendamento"));


            bd.Desconectar();

            return dt;
        }
        // Edita as informações dos agendamentos ao clicar no DGV
        public bool Editar(string codAgendamentoClicado)
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE ExecucaoAgendamento SET animal_codAnimal = '{0}', servico_codServico = '{1}', funcionario_codFuncionario = '{2}', "
                + "dataExecucao = '{3}',horaExecucao = '{4}' WHERE codExecucaoA LIKE '{5}'", codAnimal // arg 0
                , codServico // arg 1
                , codVet // arg 2
                , dataExecucao // arg 3
                , horaExecucao
                , codAgendamentoClicado
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
        // Exclui as informações dos agendamentos cadastrados
        public bool Excluir(string codAgendamentoClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM ExecucaoAgendamento WHERE codExecucaoA = '{0}'",
                codAgendamentoClicado));

            bd.Desconectar();

            return true;

        }
        // Busca os agendamentos de acordo com a data de execução
        public DataTable RetAgendamentosData(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM ExecucaoAgendamento WHERE dataExecucao like '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }
    }
}
