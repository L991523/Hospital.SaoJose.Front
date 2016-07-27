using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.SaoJose.Front.Controllers
{
    public class ConteudoController : Controller
    {
        //
        // GET: /Conteudo/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agentes()
        {
            return View();
        }

        public ActionResult Cruds()
        {
            return View();
        }

        public ActionResult Servicos()
        {
            return View();
        }
	}
}