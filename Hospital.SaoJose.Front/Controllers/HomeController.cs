using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.SaoJose.Front.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Protótipo arquitetural - Trabalho de conclusão do curso de Pós-graduação em Arquitetura de Software Distribuído.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em contato.";

            return View();
        }
    }
}