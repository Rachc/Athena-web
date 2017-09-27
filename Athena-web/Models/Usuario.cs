using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Athena_web.Models
{
    public class Usuario
    {
        public String Cpf { get; set; }
        public String Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public int Cargo { get; set; }
        public String Cnpj { get; set; }
    }
}