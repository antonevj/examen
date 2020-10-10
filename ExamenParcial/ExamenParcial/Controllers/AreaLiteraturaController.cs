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
            return View();
        }
        public ActionResult titles()
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
        public ActionResult authors()
        {
            using (var context = new pubsEntities())
            {
                //linkQ sintaxis de consulta
                //  var clientes = (from e in context.Customers select e).ToList();

                //linkQ. sintaxis de metodo

                var autor = context.authors.ToList();

                return View(autor);



            }
        }



        public ActionResult sales()
        {
            using (var context = new pubsEntities())
            {
                //linkQ sintaxis de consulta
                //  var clientes = (from e in context.Customers select e).ToList();

                //linkQ. sintaxis de metodo

                var sales = context.sales.ToList();

                return View(sales);



            }
        }


        public ActionResult employee()
        {
            using (var context = new pubsEntities())
            {
                //linkQ sintaxis de consulta
                //  var clientes = (from e in context.Customers select e).ToList();

                //linkQ. sintaxis de metodo

                var emleados = context.employees.ToList();

                return View(emleados);



            }
        }




    }
}