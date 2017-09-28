using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Athena_web.Models
{
    public class Atividade
    {
        public int Id { get; set; }
        public int IdProjeto { get; set; }
        public String Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public String Responsavel { get; set; }
        public int IdRisco { get; set; }
        public int IdRecurso { get; set; }
//todo - Definir subatividades
    }
}