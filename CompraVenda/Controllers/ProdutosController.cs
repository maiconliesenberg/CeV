using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompraVenda.Models;
namespace CompraVenda.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            var produtos = new Produtos() { name = "Produtos" };
            return View(produtos);

        }
    }
}