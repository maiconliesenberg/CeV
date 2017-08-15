using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompraVenda.Models;
namespace CompraVenda.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionario = new Funcionario() { name = "Funcionario" };
            return View(funcionario);

        }
    }
}