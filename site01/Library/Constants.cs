using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Library
{
    public class Constants
    {
        /*
         * POP3, IMAP - ler menssagens de email
         * SMTP - Enviar email
         * 
         */

        //Autenticação - Gmail
        public readonly static string Usuario = "andrexfes08@gmail.com";
        public readonly static string Senha = "8872556355";

        //Servidor SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 587;

    }
}
