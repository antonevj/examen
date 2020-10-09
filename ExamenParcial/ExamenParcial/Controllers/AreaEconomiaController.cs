using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenParcial.Controllers
{
    public class AreaEconomiaController : Controller
    {
        // GET: AreaEconomia
        public ActionResult Index()
        {
            return View();

        }

        [HttpGet]
        public ViewResult interes()

        {
            return View();
        }

        [HttpPost]
        public ActionResult interes(float capital, float tasa, float tiempo, string inte)
        {
            float rpta;

            if (inte=="simple")
            {
                rpta = (float)(capital * (tasa / 100) * tiempo);
            }
            else
            {
                rpta = (float)(capital * (1+(tasa / 100)) * tiempo);
            }
              



            ViewBag.rpta = rpta;
            ViewBag.capital = capital;
            ViewBag.tasa = tasa;
            ViewBag.inte = inte;
            ViewBag.tiempo = tiempo;
           
            return View();


        }

    }
}