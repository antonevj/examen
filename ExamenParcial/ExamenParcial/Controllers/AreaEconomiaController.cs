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
        public ActionResult Divisas(float cantidad, string select_combos1, string select_combos2)
        {
            float valor1=0;
           

                if (select_combos1 == "1" && select_combos2 == "2")
                {
                    valor1 = cantidad * 0.28f;
                }
                else if (select_combos1 == "1" && select_combos2 == "3")
                {
                    valor1 = cantidad * 0.24f;
                }
                else if (select_combos1 == "1" && select_combos2 == "4")
                {
                    valor1 = cantidad * 29.69f;
                }
                else if (select_combos1 == "1" && select_combos2 == "1")
                {
                    valor1 = cantidad ;
                }
                    
            //parte 2
            if (select_combos1 == "2" && select_combos2 == "1")
            {
                valor1 = cantidad * 3.57f;
            }
            else if (select_combos1 == "2" && select_combos2 == "3")
            {
                valor1 = cantidad * 0.85f;
            }
            else if (select_combos1 == "2" && select_combos2 == "4")
            {
                valor1 = cantidad * 105.95f;
            }

            //parte 3
            if (select_combos1 == "3" && select_combos2 == "1")
            {
                valor1 = cantidad * 4.2f;
            }
            else if (select_combos1 == "3" && select_combos2 == "2")
            {
                valor1 = cantidad * 1.18f;
            }
            else if (select_combos1 == "3" && select_combos2 == "4")
            {
                valor1 = cantidad * 124.74f;
            }
            //parte 4
            if (select_combos1 == "4" && select_combos2 == "1")
            {
                valor1 = cantidad * 0.034f;
            }
            else if (select_combos1 == "4" && select_combos2 == "2")
            {
                valor1 = cantidad * 0.0094f;
            }
            else if (select_combos1 == "4" && select_combos2 == "3")
            {
                valor1 = cantidad * 0.0080f;
            }


            ViewBag.select_combos1 = select_combos1;
            ViewBag.select_combos2 = select_combos2;
            ViewBag.cantidad = cantidad;
            ViewBag.valor1 = valor1;
            return View();
        }

      
    }
}