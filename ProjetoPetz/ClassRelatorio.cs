using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoZeeDog
{
    class ClassRelatorio
    {
        ClassAnimal animal = new ClassAnimal();
        ClassAcessoBD bd = new ClassAcessoBD();

        public DataTable BuscaAnimais()
        {
            bd.Conectar();
            // Seleciona informações do animal e do cliente para o DGV
            DataTable dt = bd.RetDataTable(String.Format("SELECT A.nome, C.nome, C.telefone FROM Animal AS A INNER JOIN Cliente AS C ON A.cliente_codCliente = C.codCliente"));

            bd.Desconectar();
            return dt;
        }

        public DataTable MovimentoDia(string dia)
        {
            bd.Conectar();
            // Calcula o valor dos serviços realiados no dia e os soma para mostrar no DGV
            DataTable dt = bd.RetDataTable(String.Format("SELECT SUM(S.valorServico) AS 'Rendimento do Dia' FROM Servico AS S INNER JOIN ExecucaoAgendamento AS E ON S.codServico = E.servico_codServico WHERE dataExecucao = '{0}'", dia));
            bd.Desconectar();
            return dt;
        }
    }
}
