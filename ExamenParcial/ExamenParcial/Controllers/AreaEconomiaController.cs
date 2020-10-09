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
        public ActionResult Divisas()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Divisas(float divisa1, float divisa2)
        {

            return View();
        }

      
    }
}