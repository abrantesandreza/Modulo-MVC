using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Modulo_MVC.Repositories;

namespace Modulo_MVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaRepository _dbContext;

        public ContatoController(AgendaRepository dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var contatos = _dbContext.Contatos.ToList();
            return View(contatos);
        }
    }
}