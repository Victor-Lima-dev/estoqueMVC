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
    public class EstoqueController : Controller
    {
        private readonly ILogger<EstoqueController> _logger;
        private readonly AppDbContext _context;
        private readonly Estoque _estoque;


        public EstoqueController(ILogger<EstoqueController> logger, AppDbContext context, Estoque estoque)
        {
            _logger = logger;
            _context = context;
            _estoque = estoque;
        }

        //gerar estoque
        [HttpPost("gerar")]
        public IActionResult GerarT()
        {
            var estoque = new Estoque();
            _context.Estoque.Add(estoque);
            _context.SaveChanges();
            //return redirect
            return RedirectToAction("Gerar");
        }

        //http get gerar
        [HttpGet("gerar")]
        public IActionResult Gerar()
        {
            return View();
        }

        //listar estoque
        [HttpGet("listar")]
        public IActionResult Listar()
        {
            //listar os itens dentro do estoque de id 1
            var estoque = _context.Estoque.FirstOrDefault(x => x.EstoqueId == 2);
            var listaItens = _context.ItensEstoque.Where(x => x.EstoqueId == 2).ToList();
            //pegar cada ItemEstoque e pegar o produto relacionado
            foreach (var item in listaItens)
            {
                item.Produto = _context.Produtos.FirstOrDefault(x => x.ProdutoId == item.ProdutoId);
            }
            return View(listaItens);
        }

        //http get adicionar
        [HttpGet("Adicionar")]
        public IActionResult Adicionar()
        {
            var produtos = _context.Produtos.ToList();

            return View(produtos);
        }



        [HttpPost("Adicionar")]
        public IActionResult Adicionar(int produtoId, int quantidade)
        {
            //procurar produto
            var produto = _context.Produtos.FirstOrDefault(x => x.ProdutoId == produtoId);    

            // Verificar se existe um itemEstoque com o mesmo produto
            var itemEstoque = _context.ItensEstoque.FirstOrDefault(x => x.ProdutoId == produtoId);
            if (itemEstoque == null)
            {
                // Se não existir, criar um novo itemEstoque
                itemEstoque = new ItemEstoque();
                itemEstoque.ProdutoId = produtoId;
                itemEstoque.Quantidade = quantidade;
                itemEstoque.AdicionarDataEntradaValidade(itemEstoque);
                itemEstoque.Produto = produto;
                itemEstoque.EstoqueId = 2;
            
                _context.ItensEstoque.Add(itemEstoque);
                
                _context.SaveChanges();
            }
            else
            {
                // Se existir, atualizar a quantidade
                itemEstoque.Quantidade += quantidade;
                _context.ItensEstoque.Update(itemEstoque);
                _context.SaveChanges();
            }
            // Return redirect
            return RedirectToAction("Listar");
        }


        //http post apagar
        [HttpPost]
        public IActionResult Apagar(int produtoId)
        {
            var itemEstoque = _context.ItensEstoque.FirstOrDefault(x => x.ProdutoId == produtoId);
            _context.ItensEstoque.Remove(itemEstoque);
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }


        //http get detalhes
        [HttpGet("detalhes/{produtoId}")]
        public IActionResult Detalhes(int produtoId)
        {
            var itemEstoque = _context.ItensEstoque.FirstOrDefault(x => x.ProdutoId == produtoId);
            itemEstoque.Produto = _context.Produtos.FirstOrDefault(x => x.ProdutoId == itemEstoque.ProdutoId);        
            return View(itemEstoque);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}