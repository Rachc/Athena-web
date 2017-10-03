using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Athena_web.Models;
using Athena_web.ViewModel;

namespace Athena_web.Controllers
{
    public class ProjetosController : Controller
    {
        // GET: Projetos
        public ActionResult ListaProjetos()
        {
            var projetos = GetProjetos();

            var viewModel = new ProjetosControllerViewModel
            {
                Projetos = projetos
            };

            return PartialView(viewModel);
        }
        private IEnumerable<Projeto> GetProjetos()
        {
            List<Projeto> lstProj = new List<Projeto>
            {
                new Projeto {Id = 1, Nome = "Projeto A"},
                new Projeto {Id = 1, Nome = "Projeto 2"},
                new Projeto {Id = 3, Nome = "Projeto C"}
            };

            return lstProj;
        }
    }
}