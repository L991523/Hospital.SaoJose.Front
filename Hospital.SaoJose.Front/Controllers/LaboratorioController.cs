using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital.SaoJose.Negocios;

namespace Hospital.SaoJose.Front.Controllers
{
    public class LaboratorioController : Controller
    {
        // GET: Laboratorio
        public ActionResult Index()
        {
            //List<Laudo> listaLaudos;
            //Hospital.SaoJose.Laboratorio.LaboratorioClient resultLaboratorio = new Hospital.SaoJose.Laboratorio.LaboratorioClient();

            return View();
        }
    }
}