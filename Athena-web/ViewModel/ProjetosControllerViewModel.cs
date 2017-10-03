using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Athena_web.Models;

namespace Athena_web.ViewModel
{
    public class ProjetosControllerViewModel
    {
        public IEnumerable<Projeto> Projetos { get; set; }
    }
}