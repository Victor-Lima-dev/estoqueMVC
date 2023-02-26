using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueMVC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }  
        //um para muitos com item estoque
        public ICollection<ItemEstoque> ItensEstoque { get; set; } = new List<ItemEstoque>();   
    }
}