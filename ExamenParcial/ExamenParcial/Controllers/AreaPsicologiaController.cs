using ExamenParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Schema;

namespace ExamenParcial.Controllers
{
    public class AreaPsicologiaController : Controller
    {
        // GET: AreaPsicologia
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TestEstres()
        {
            return View();
        }
        [HttpPost]
        public ViewResult TestEstres(Test test)
        {
            string resultado = "";

            if (test.GradoEstres() <= 24)
            {
                resultado = "No existe síntoma alguno de estrés,Tienes un buen equilibrio, continúa así y contagia a losdemás de tus estrategias de afrontamiento!";
            }
            else if (test.GradoEstres() <= 36)
            {
                resultado = "Te encuentras en fase de alarma, trata de identificar el o los factores que te causan estrés para poder ocuparte de ellos de manera preventiva.";
            }
            else if (test.GradoEstres() <= 48)
            {
                resultado = "Haz conciencia de la situación en la que te encuentras y trata de ubicar qué puedes modificar, ya que si la situación estresante se prolonga, puedes romper tu equilibrio entre lo laboral y lo personal.No agotes tus resistencias!";
            }
            else if (test.GradoEstres() <= 60)
            {
                resultado = "Te encuentras en una fase de agotamiento de recursos fisiológicos con desgaste físico y mental. Esto puede tener consecuencias más serias para tu salud. ";
            }
            else
            {
                resultado = "Busca Ayuda";
            }
            ViewBag.resultado = resultado;
            ViewBag.total = test.GradoEstres();
            return View();
        }

    }
}