using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Athena_web.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public String Remetente { get; set; }
        public String Destinatario { get; set; }
        public String CorpoMensagem { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataLeitura { get; set; }
        public bool Lida { get; set; }
        //todo - Adicionar no banco o status se ela foi lida ou não
    }
}