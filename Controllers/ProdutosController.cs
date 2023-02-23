using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using estoqueMVC.context;
using estoqueMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace estoqueMVC.Controllers
{
    [Route("[controller]")]
    public class ProdutosController : Controller
    {
        private readonly ILogger<ProdutosController> _logger;
        private readonly AppDbContext _context;

        //construtor
        public ProdutosController(ILogger<ProdutosController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        [Route("Index")]
         public IActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            var produtosViewModel = new ProdutosViewModel();
            produtosViewModel.Produtos = produtos;
            return View(produtosViewModel);
        }

        [HttpGet("Cadastrar")]
        public IActionResult Cadastrar()
        {        
            return View();
        }

        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                produto.CadastrarProduto(produto);
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}