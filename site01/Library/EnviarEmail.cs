using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using site01.Models;

namespace site01.Library
{
    public class EnviarEmail
    {
        public static void EnviarMessagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome:{0}<br/>Email:{1}<br/>Assunto:{2}<br/>Menssagem:{3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
            //Configurar Servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true; // abilitar o ssl
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            //Messagem de Email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("andrexfes08@gmail.com");
            mensagem.To.Add("andrexfes08@gmail.com");
            mensagem.Subject = "Formulário de Contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de Contato</h1> " + conteudo;       
            
        }
        
        
    }
}
