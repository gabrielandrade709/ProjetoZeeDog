using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace ProjetoZeeDog
{
    class ClassRecuperar
    {
        public string EmailEsquecido { get; set; }
        ClassAcessoBD bd = new ClassAcessoBD();

        public static void EnvioEmail(string email, string senha)
        {
            frmEsqueceu recuperar = new frmEsqueceu();
            var client = new SmtpClient("smtp.gmail.com", 587)// Configura os parâmentros do gmail
            {
                Credentials = new NetworkCredential("petzspc@gmail.com", "petz1234"), // Email que enviará a senha
                EnableSsl = true
            };
            try
            {
                //Mensagem que o email irá mandar 
                client.Send("petzspc@gmail.com", email, " Recuperação de senha Petz", " a sua senha é " + senha + ".");
            }
            catch
            {
                recuperar.SemInternet();
            }
        }
        public bool EsqueceuSenha()
        {// Verifica se o email inserido para a recuperação está correto
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE email LIKE '{0}'", EmailEsquecido));
            bd.Desconectar();
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {// Se achar algum meio inserido verifica no banco de dados o email e a senha e envia a mesma para o usuário.
                string emailRegistrado = dt.Rows[0]["email"].ToString();
                string senhaRegistrada = dt.Rows[0]["senha"].ToString();
                EnvioEmail(emailRegistrado, senhaRegistrada);
                return true;
            }
        }
    }
}

