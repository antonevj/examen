using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenParcial.Controllers
{
    public class AreaFinanzasController : Controller
    {
        // GET: AreaFinanzas
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
        public ActionResult interes(float capital, float tasa, float tiempo, string promo1, string promo2)
        {
            float rpta=0;

            if (promo1 == "1")
            {
                rpta = (float)(capital * (tasa / 100) * tiempo);
            }
            if(promo2=="2")
            {
                rpta = (float)(capital * (1 + (tasa / 100)) * tiempo);
            }




            ViewBag.rpta = rpta;
            ViewBag.capital = capital;
            ViewBag.tasa = tasa;
           // ViewBag.inte = inte;
            ViewBag.tiempo = tiempo;

            return View();


        }

    }
}