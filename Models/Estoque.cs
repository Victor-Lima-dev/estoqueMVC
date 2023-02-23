using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueMVC.Models
{
    public class Estoque
    {
        public int EstoqueId { get; set; }
        //relação de 1 para muitos com a classe ItemEstoque
        public List<ItemEstoque> ItensEstoque { get; set; } = new List<ItemEstoque>();
    }
}