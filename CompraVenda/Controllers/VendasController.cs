using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompraVenda.Models;
namespace CompraVenda.Controllers
{
    public class VendasController : Controller
    {
        // GET: Vendas
        public ActionResult Index()
        {
            var vendas = new Vendas() { name = "Vendas" };
            return View(vendas);

        }
    }
}