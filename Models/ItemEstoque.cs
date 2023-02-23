using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueMVC.Models
{
    public class ItemEstoque
    {
        public int ItemEstoqueId { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        //relação de 1 para 1 com a classe Produto
        public Produto Produto { get; set; }

        //relação de muitos para 1 com a classe Estoque
        public int EstoqueId { get; set; }
    }
}