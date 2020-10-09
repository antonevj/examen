using ExamenParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenParcial.Controllers
{
    public class AreaLiteraturaController : Controller
    {
        // GET: AreaLiteratura
        public ActionResult Index()
        {
            using (var context = new pubsEntities())
            {
                //linkQ sintaxis de consulta
                //  var clientes = (from e in context.Customers select e).ToList();

                //linkQ. sintaxis de metodo

                var titulos = context.titles.ToList();

                return View(titulos);



            }
        }
    }
}